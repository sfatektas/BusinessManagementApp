using BusinessManagementApp.Common.Enums;
using BusinessManagementApp.UI.Helpers.Models;
using BusinessManagementApp.UI.Helpers;
using BusinessManagementApp.UI.Interfaces;
using BussinesManagementApp.Bussines.Interfaces;
using BussinesManagementApp.Bussines.Services;
using Microsoft.Extensions.DependencyInjection;
using BussinesManagementApp.Dtos;
using BusinessManagementApp.Common.Consts;
using AutoMapper;

namespace BusinessManagementApp.UI.Forms
{
    public partial class UrunAlımı : Form, INodeable
    {
        readonly IServiceProvider _serviceProvider;
        readonly IProductService _productService;
        readonly ISupplierOrderService _supplierOrderService;
        readonly IWarehouseProductService _warehouseService;
        readonly IMapper _mapper;
        ProductListDto _productListDto;

        public bool ConfirmIsOk { get; set; }
        public double MoneyMultiplier { get; set; }
        public double UnitPrice { get; set; }
        public int Amount { get; set; }
        public UrunAlımı(IServiceProvider serviceProvider, IProductService productService, ISupplierOrderService supplierOrderService, IWarehouseProductService warehouseService, IMapper mapper)
        {
            _supplierOrderService = supplierOrderService;
            _serviceProvider = serviceProvider;
            _productService = productService;
            _warehouseService = warehouseService;
            _mapper = mapper;
            InitializeComponent();
            this.Show();
        }

        public Form _prev { get; set; }

        public async Task ComboboxItemLoad()
        {
            //Money Values 
            HelperMethods.BindToComboboxMoneyTypeAndValues(new() { MoneyTypeCombobox });
            //
            var response = await _productService.GetAllAsync(x => x.IsActive == true);
            if (response.ResponseType == ResponseType.Success)
            {
                var items = new List<ComboboxModel>() { };
                foreach (var item in response.Data)
                {
                    items.Add(new() { Text = item.Name, Value = item.Id });
                }
                HelperMethods.ComboboxListBindToCombobox(items, new List<ComboBox>() { SelectProductCombobox });
            }
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void UrunAlımı_Load(object sender, EventArgs e)
        {
            Task comboboxBind = ComboboxItemLoad();

            ProductName_txt.Enabled = false;
            TotalPrice_txt.Enabled = false;
            SupplierName_txt.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            _prev.Show();
        }

        private void AddNewProduct_btn_Click(object sender, EventArgs e)
        {
            var urunekleform = _serviceProvider.GetRequiredService<UrunEkle>();
            urunekleform._prev = this;
            this.Close();
        }
        public async Task GetDataWithInclude(int id)
        {
            if (_productListDto == null || (_productListDto.Id != id)) // aynı ürün seçildiyse eğer tekrardan istek atmasın
            {
                var response = await _productService.GetIncludedById(id);
                if (response.ResponseType == ResponseType.Success)
                {
                    _productListDto = response.Data;
                }
                SupplierName_txt.Text = _productListDto.Supplier.Info;
                ProductName_txt.Text = _productListDto.Name;
            }
        }
        private void SelectProductCombobox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Task getitemfromid = GetDataWithInclude((int)SelectProductCombobox.SelectedValue);
        }

        private void MoneyTypeCombobox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            switch ((int)MoneyTypeCombobox.SelectedValue)
            {
                case (int)MoneyType.TL:
                    MoneyMultiplier = MoneyValues.TL;
                    break;
                case (int)MoneyType.Dolar:
                    MoneyMultiplier = MoneyValues.Dolar;
                    break;
                case (int)MoneyType.Euro:
                    MoneyMultiplier = MoneyValues.Euro;
                    break;
                default:
                    break;
            }
            MoneyValues_txt.Text = MoneyMultiplier.ToString();
            RefreshTotalPrice();
        }

        public void RefreshTotalPrice()
        {
            if (this.UnitPrice != 0 && this.Amount != 0 && this.MoneyMultiplier != 0)
            {
                TotalPrice_txt.Text = (this.UnitPrice * this.Amount * this.MoneyMultiplier).ToString("0.##");
            }
        }
        private void UnitPrice_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            HelperMethods.IsOkPriceFormat(ref sender, e);
            if (!char.IsControl(e.KeyChar) && !e.Handled) // handle yapısı !handle olarak kullanılmalı.
            {
                UnitPrice = UnitPrice_txt.Text + e.KeyChar.ToString() == "" ? 0 : double.Parse(UnitPrice_txt.Text + e.KeyChar.ToString());
            }
            RefreshTotalPrice();
        }

        private void Amount_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            HelperMethods.IsOkNumberFormat(ref sender, e);
            if (!char.IsControl(e.KeyChar) && !e.Handled)
            {
                Amount = Amount_txt.Text + e.KeyChar.ToString() == "" ? 0 : int.Parse(Amount_txt.Text + e.KeyChar.ToString());
            }
            RefreshTotalPrice();
        }
        public async Task AddSupplierOrderAndWarehouseProduct()//TODO servise ayrı bir method yapılım 3 işlemin tracking durumu aynı anda işlenmeli.
        {
            var response = await _supplierOrderService.CreateAsync(new SupplierOrderCreateDto() // Tedarikçi siparişi 
            {
                Amount = this.Amount,
                MoneyTypeId = (int)MoneyTypeCombobox.SelectedValue,
                ProductId = (int)SelectProductCombobox.SelectedValue,
                TotalPrice = double.Parse(TotalPrice_txt.Text),
                UnitPrice = this.UnitPrice
            });

            if (response.ResponseType == ResponseType.ValidationError)
                HelperMethods.ShowErrors(response.ValidationErrors);
            else if (response.ResponseType == ResponseType.Success)
            {
                var ProductResponse = await _productService.GetByIdAsync(response.Data.ProductId);

                ProductResponse.Data.UnitPrice = ProductResponse.Data.UnitPrice == 0 ? this.UnitPrice * 1.25 : this.UnitPrice; // varsayılan olarak %25 değerini atıyorum. daha önceden bir fiyat değişimi yapılmadıysa

                var responseProduct = await _productService.UpdateAsync(_mapper.Map<ProductUpdateDto>(ProductResponse.Data));
                
                if (responseProduct.ResponseType == ResponseType.Success)
                {
                    var ResponseWarehouseProductExist = await _warehouseService.GetByIdAsync(response.Data.ProductId); // Bu ürünün depoda daha önceden olma durumu ? 
                    if (ResponseWarehouseProductExist.Data != null)
                    {
                        ResponseWarehouseProductExist.Data.Amount += this.Amount; //ürünün depodaki miktarını arttırıyorum.

                        var warehouseproductUpdate = await _warehouseService.UpdateAsync(_mapper.Map<WarehouseProductUpdateDto>(ResponseWarehouseProductExist.Data));
                        if (warehouseproductUpdate.ResponseType != ResponseType.Success)
                            MessageBox.Show("Ürün stoğu güncellenirken bir hata oluştu.");
                    }
                    else
                    {
                        var responseWarehouseAdd = await _warehouseService.CreateAsync(new() { Amount = this.Amount, ProductId = response.Data.ProductId });
                        if (responseWarehouseAdd.ResponseType == ResponseType.Success)
                        {
                            MessageBox.Show(responseWarehouseAdd.Message);
                        }
                    }
                }
            }
            MessageBox.Show(response.Message);

        }
        private void AddProductOrder_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Emin misiniz?", "Onay", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Task addOrder = AddSupplierOrderAndWarehouseProduct();

            }
        }

        private void UnitPrice_txt_KeyDown(object sender, KeyEventArgs e)
        {
            //Amount = Amount_txt.Text == "" ? 0 : int.Parse(Amount_txt.Text);
            //RefreshTotalPrice();
        }

        private void Amount_txt_KeyDown(object sender, KeyEventArgs e)
        {
            //UnitPrice = UnitPrice_txt.Text == "" ? 0 : double.Parse(UnitPrice_txt.Text);
            //RefreshTotalPrice();
        }
    }
}

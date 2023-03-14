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
            await MoneyValuesProvider.GetValues(); // Api ile çekilen para değerlerinin api ile değerlerini çekiyorum

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
            //this.Close();
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
                    MoneyMultiplier = 1;
                    break;
                case (int)MoneyType.Dolar:
                    MoneyMultiplier = MoneyValuesProvider.Dolar;
                    break;
                case (int)MoneyType.Euro:
                    MoneyMultiplier = MoneyValuesProvider.Euro;
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
                try
                {
                    Amount = Amount_txt.Text + e.KeyChar.ToString() == "" ? 0 : int.Parse(Amount_txt.Text + e.KeyChar.ToString());

                }
                catch (Exception)
                {
                    MessageBox.Show("Miktar alanı istenilen formatta değil.");
                }
            }
            RefreshTotalPrice();
        }
        public async Task AddSupplierOrderAndWarehouseProduct()
        {
            try
            {
                var response = await _supplierOrderService.AddSupplierOrderAndWarehouseProductUpdate(new SupplierOrderCreateDto() // Tedarikçi siparişi 
                {
                    Amount = this.Amount,
                    MoneyTypeId = (int)MoneyTypeCombobox.SelectedValue,
                    ProductId = (int)SelectProductCombobox.SelectedValue,
                    TotalPrice = HelperMethods.doubleParseWithError(TotalPrice_txt.Text),
                    UnitPrice = this.UnitPrice,
                    MoneyTypeValue = MoneyMultiplier
                });
                if (response.ResponseType == ResponseType.ValidationError)
                {
                    HelperMethods.ShowErrors(response.ValidationErrors);
                }
                else
                    MessageBox.Show(response.Message);
            }
            catch (Exception e)
            {
                MessageBox.Show("Bir sorun oluştu : "+e.Message);
                throw;
            }

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

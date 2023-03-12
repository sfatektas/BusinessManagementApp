using BusinessManagementApp.Common.Enums;
using BusinessManagementApp.UI.Helpers.Models;
using BusinessManagementApp.UI.Helpers;
using BusinessManagementApp.UI.Interfaces;
using BussinesManagementApp.Bussines.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using BussinesManagementApp.Dtos;

namespace BusinessManagementApp.UI.Forms
{
    public partial class UrunSat : Form, INodeable
    {
        readonly IProductService _productService;
        readonly IWarehouseProductService _warehouseProductService;
        readonly ICustomerService _customerService;
        readonly IServiceProvider _serviceProvider;
        readonly ICustomerOrderService _customerOrderService;
        readonly CustomerOrderCreateDto _customerOrderCreateDto = new();

        Dictionary<int,int> warehouseProductkeyValuePair = new Dictionary<int,int>();

        public Form _prev
        {
            get; set;
        }

        public double UnitPrice { get; set; }
        public int Amount { get; set; }
        public double TotalPrice { get; set; }
        public double KdvTotal { get; set; }
        public double UnitTotalPrice { get; set; }
        public UrunSat(IProductService productService, ICustomerService customerService, IServiceProvider serviceProvider, IWarehouseProductService warehouseProductService, ICustomerOrderService customerOrderService)
        {
            _customerService = customerService;
            _productService = productService;
            _serviceProvider = serviceProvider;
            _warehouseProductService = warehouseProductService;
            _customerOrderService = customerOrderService;
            InitializeComponent();
            UpdateProductUnitPrice_btn.Enabled = false;
            this.Show();

        }

        public async Task ComboboxCustomersItemLoad()
        {
            var response = await _customerService.GetAllAsync(x => x.IsActive == true);
            if (response.ResponseType == ResponseType.Success)
            {
                var items = new List<ComboboxModel>() { };
                foreach (var item in response.Data)
                {
                    items.Add(new() { Text = item.CominicatePersonName, Value = item.Id });
                }
                HelperMethods.ComboboxListBindToCombobox(items, new List<ComboBox>() { SelectCustomerCombobox });
            }
        }
        public async Task ComboboxProductItemLoad()
        {
            var response = await _warehouseProductService.GetIncludedAll(x => x.IsActive == true);
            if (response.ResponseType == ResponseType.Success)
            {
                var items = new List<ComboboxModel>() { };
                foreach (var item in response.Data)
                {
                    items.Add(new() { Text = item.Product.Name, Value = item.Id }); // TODO bir yerde Product Id Tutulmalı
                    warehouseProductkeyValuePair.Add(item.Id, item.ProductId);
                }
                HelperMethods.ComboboxListBindToCombobox(items, new List<ComboBox>() { SelectProductCombobox });
            }
        }
        public async Task LoadComboboxItems()
        {
            await ComboboxCustomersItemLoad();
            await ComboboxProductItemLoad();
        }

        private void UrunSat_Load(object sender, EventArgs e)
        {
            Task loadItem = LoadComboboxItems();
        }

        private void AddNewCustomer_btn_Click(object sender, EventArgs e)
        {
            var musteriEkleForm = _serviceProvider.GetRequiredService<MusteriEkle>();
            musteriEkleForm._prev = this;
        }
        public async Task GetByIdProductToBindTextBox(int findid = 0)
        {

            if ((int)SelectProductCombobox.SelectedValue != 0 || findid != 0)
            {
                UpdateProductUnitPrice_btn.Enabled = true; // Eğer ürünün fiyatını değiştirmek istersek buradan yönetilebilir.
                var WarehouseproductId = findid == 0 ? (int)SelectProductCombobox.SelectedValue : findid;
                var response = await _warehouseProductService.GetIncludedById(WarehouseproductId);
                if (response.ResponseType == ResponseType.Success)
                {
                    AmountLabel.Text = response.Data.Amount.ToString();
                    ProductName_txt.Text = response.Data.Product.Name;
                    UnitPrice_txt.Text = response.Data.Product.UnitPrice.ToString();
                    this.UnitPrice = response.Data.Product.UnitPrice;
                    SelectProductCombobox.SelectedValue = response.Data.Id; // find txt ile olan data uyuşmazlığını kontrol etmek için 
                }
            }
            else
            {
                HelperMethods.ClearTextBox(new() { ProductName_txt, UnitPrice_txt, TotalPrice_txt, KdvPrice_txt, Amount_txt });
                UpdateProductUnitPrice_btn.Enabled = false;
            }

        }

        private void Find_btn_Click(object sender, EventArgs e)
        {
            if (FindProduct_txt.Text != "")
            {
                int productId = int.Parse(FindProduct_txt.Text);
                Task bindItem = GetByIdProductToBindTextBox(productId);
                RefreshTotalPrice();
            }
        }

        private void FindProduct_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            HelperMethods.IsOkNumberFormat(ref sender, e);
        }

        private void Amount_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            HelperMethods.IsOkNumberFormat(ref sender, e);

            if (!e.Handled)
            {
                //Todo backspace geldiğinde textboxu güncelle
                if (e.KeyChar != '\b')
                {
                    try
                    {
                        this.Amount = Amount_txt.Text + e.KeyChar.ToString() == "" ? 0 : int.Parse(Amount_txt.Text + e.KeyChar.ToString());
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Miktar alanı uygun formatta değil");
                    }

                }

            }
            RefreshTotalPrice();
        }

        public void RefreshTotalPrice()
        {
            if (this.UnitPrice != 0 && this.Amount != 0)
            {
                this.UnitTotalPrice = this.Amount * this.UnitPrice;
                this.KdvTotal = this.UnitTotalPrice * 0.18;
                this.TotalPrice = this.UnitTotalPrice + this.KdvTotal;
                TotalPrice_txt.Text = (TotalPrice).GetStringMoneyFormat();
                KdvPrice_txt.Text = this.KdvTotal.GetStringMoneyFormat();
                UnitPrice_txt.Text = this.UnitPrice.GetStringMoneyFormat();
                UnitTotalPrice_txt.Text = this.UnitTotalPrice.GetStringMoneyFormat();
            }
        }

        private void return_btn_Click(object sender, EventArgs e)
        {
            _prev.Show();
            this.Close();
        }
        public async Task AddOrder()
        {
            KeyValuePair<int, int> WarehousekeyValuePair = warehouseProductkeyValuePair.Where(x => x.Key == (int)SelectProductCombobox.SelectedValue).FirstOrDefault();
            // bind Items
            _customerOrderCreateDto.ProductId = WarehousekeyValuePair.Value;
            _customerOrderCreateDto.Amount = this.Amount;
            _customerOrderCreateDto.UnitPrice = this.UnitPrice;
            _customerOrderCreateDto.KdvPrice = this.KdvTotal;
            _customerOrderCreateDto.TotalPrice = this.TotalPrice;
            _customerOrderCreateDto.OrderStatusTypeId = _customerOrderCreateDto.OrderStatusTypeId == 0 ?
                (int)OrderStatusType.Complated : _customerOrderCreateDto.OrderStatusTypeId;

            var response = await _customerOrderService.AddCustomerOrderAndUpdateWarehouse(this._customerOrderCreateDto);
            if (response.ResponseType == ResponseType.ValidationError)
            {
                HelperMethods.ShowErrors(response.ValidationErrors);
            }
            else
                MessageBox.Show(response.Message);
            if(response.ResponseType == ResponseType.Success) 
                HelperMethods.ClearTextBox(new() { ProductName_txt, UnitPrice_txt, TotalPrice_txt, KdvPrice_txt, Amount_txt });

        }
        private void ComplateOrder_btn_Click(object sender, EventArgs e)
        {
            if (HelperMethods.AreYouSure())
            {
                Task addOrder = AddOrder();
            }
        }

        private void SelectCustomerCombobox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            _customerOrderCreateDto.CustomerId = (int)SelectCustomerCombobox.SelectedValue;
        }

        private void SelectProductCombobox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Task bindItems = GetByIdProductToBindTextBox();

        }

        private void PreOrder_btn_Click(object sender, EventArgs e)
        {
            if (HelperMethods.AreYouSure())
            {
                _customerOrderCreateDto.OrderStatusTypeId = (int)OrderStatusType.PreOrder;
                Task addOrder = AddOrder();
            }
        }
    }
}

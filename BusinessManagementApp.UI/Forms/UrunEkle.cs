using BusinessManagementApp.Common.Enums;
using BusinessManagementApp.UI.Helpers.Models;
using BusinessManagementApp.UI.Helpers;
using BusinessManagementApp.UI.Interfaces;
using BussinesManagementApp.Bussines.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessManagementApp.Common;
using Microsoft.Extensions.DependencyInjection;

namespace BusinessManagementApp.UI.Forms
{
    public partial class UrunEkle : Form ,INodeable
    {
        readonly ISupplierService _supplierService;
        readonly IProductService _productService;
        readonly IServiceProvider _serviceProvider;
        public UrunEkle(ISupplierService supplierService, IProductService productService, IServiceProvider serviceProvider)
        {
            _supplierService = supplierService;
            _productService = productService;
            _serviceProvider = serviceProvider;
            InitializeComponent();
            this.Show();
        }

        public Form _prev { get; set; }

        public async Task ComboboxItemLoad()
        {
            var response = await _supplierService.GetAllAsync(x => x.IsActive == true);
            if (response.ResponseType == ResponseType.Success)
            {
                var items = new List<ComboboxModel>() { };
                foreach (var item in response.Data)
                {
                    items.Add(new() { Text = item.Info, Value = item.Id });
                }
                HelperMethods.ComboboxListBindToCombobox(items, new List<System.Windows.Forms.ComboBox>() { SupplierSellect_combobox });
            }
        }

        private void UrunEkle_Load(object sender, EventArgs e)
        {
            Task loadItem = ComboboxItemLoad();
        }

        public async Task AddProductAsync()
        {
            if (HelperMethods.IsNotNull(new List<TextBox> { AddOrigin_txt, AddProductName_txt, AddUnitPrice }) &&
    (int)SupplierSellect_combobox.SelectedValue != 0)
            {
                var response = await _productService.CreateAsync(new()
                {
                    Name = AddProductName_txt.Text,
                    Origin = AddOrigin_txt.Text,
                    SupplierId = (int)SupplierSellect_combobox.SelectedValue,
                    UnitPrice = Double.Parse(AddUnitPrice.Text)
                });
                if (response.ResponseType == ResponseType.ValidationError)
                {
                    HelperMethods.ShowErrors(response.ValidationErrors);
                }
                else
                {
                    MessageBox.Show(response.Message);
                    HelperMethods.ClearTextBox(new() { AddProductName_txt, AddOrigin_txt, AddUnitPrice });
                }
            }
            else
                MessageBox.Show("Lütfen Gerekli alanları doldurunuz.");
        }
        private void AddProduct_btn_Click(object sender, EventArgs e)
        {
            Task addproducttask = AddProductAsync();
        }

        private void AddUnitPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            HelperMethods.IsOkPriceFormat(ref sender ,e);
        }

        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            _serviceProvider.GetRequiredService<UrunAlımı>();
            this.Close();
        }
    }
}

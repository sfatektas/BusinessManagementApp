using BusinessManagementApp.Common.Enums;
using BusinessManagementApp.UI.Helpers.Models;
using BusinessManagementApp.UI.Helpers;
using BusinessManagementApp.UI.Interfaces;
using BussinesManagementApp.Bussines.Interfaces;
using BussinesManagementApp.Bussines.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessManagementApp.UI.Forms
{
    public partial class UrunAlımı : Form , INodeable
    {
        readonly IServiceProvider _serviceProvider;
        readonly IProductService _productService;
        public UrunAlımı(IServiceProvider serviceProvider, IProductService productService)
        {
            _serviceProvider = serviceProvider;
            _productService = productService;
            InitializeComponent();
            this.Show();
        }

        public Form _prev { get; set; }

        public async Task ComboboxItemLoad()
        {
            var response = await _productService.GetAllAsync(x => x.IsActive == true);
            if (response.ResponseType == ResponseType.Success)
            {
                var items = new List<ComboboxModel>() { };
                foreach (var item in response.Data)
                {
                    items.Add(new() { Text = item.Name, Value = item.Id });
                }
                HelperMethods.ComboboxListBindToCombobox(items, new List<System.Windows.Forms.ComboBox>() { SelectProductCombobox });
            }
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void UrunAlımı_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            _prev.Show();
        }

        private void AddNewProduct_btn_Click(object sender, EventArgs e)
        {
            var urunekleform = _serviceProvider.GetRequiredService<UrunEkle>();
            urunekleform._prev= this;
            this.Close();
        }
    }
}

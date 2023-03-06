using BusinessManagementApp.UI.Helpers.Models;
using BusinessManagementApp.UI.Interfaces;
using BussinesManagementApp.Bussines.Interfaces;
using BussinesManagementApp.Dtos;
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
    public partial class DepodakiUrunler : Form , INodeable
    {
        readonly IWarehouseProductService _warehouseService;
        readonly IServiceProvider _serviceProvider;

        public DepodakiUrunler(IWarehouseProductService warehouseService, IServiceProvider serviceProvider)
        {
            _warehouseService = warehouseService;
            _serviceProvider = serviceProvider;
            InitializeComponent();
            this.Show();
        }

        public Form _prev { get; set; }

        public List<WarehouseProductDataGridModel> ChangeModelType(List<WarehouseProductListDto> warehouseProductLists)
        {
            var list = new List<WarehouseProductDataGridModel>();
            foreach (var item in warehouseProductLists)
            {
                list.Add(new() { Amount = item.Amount, ID = item.Id, ProductName = item.Product.Name });
            }
            return list;
        }

        public async Task AllProduct()
        {
            var response = await _warehouseService.GetIncludedAll();
            if (response != response.Data)
            {
                dataGridView1.DataSource = ChangeModelType(response.Data);
                dataGridView1.Columns[0].HeaderText = "Ürün Id";
                dataGridView1.Columns[1].HeaderText = "Ürün Adı";
                dataGridView1.Columns[2].HeaderText = "Ürün Miktarı";
            }
            dataGridView1.ReadOnly = true;
        }
        private void DepodakiUrunler_Load(object sender, EventArgs e)
        {
            Task warehouseProducts = AllProduct();
        }


        private void TurnBack_btn_Click(object sender, EventArgs e)
        {
            _prev.Show();
            this.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var Productid =(int)(sender as DataGridView).Rows[e.RowIndex].Cells[0].Value;
            var formdepodakiurundetay = _serviceProvider.GetRequiredService<DepodakiUrunDetay>(); 
            formdepodakiurundetay.ProductId = Productid;
            Task detayLoad = formdepodakiurundetay.GetData();
        }
    }
}

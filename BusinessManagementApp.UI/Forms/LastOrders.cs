using BusinessManagementApp.UI.Helpers;
using BusinessManagementApp.UI.Helpers.Models;
using BusinessManagementApp.UI.Interfaces;
using BussinesManagementApp.Bussines.Interfaces;
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
    public partial class LastOrders : Form ,INodeable
    {
        readonly ICustomerOrderService _customerOrderService;
        readonly IServiceProvider _serviceProvider;
        List<CustomerOrderDataGridModel> list;
        public LastOrders(ICustomerOrderService customerOrderService, IServiceProvider serviceProvider)
        {
            _customerOrderService = customerOrderService;
            _serviceProvider = serviceProvider;
            InitializeComponent();
            this.Show();
        }

        public Form _prev { get; set; }

        public async Task BindData()
        {
            var response = await _customerOrderService.GetIncludeAllAndLastTenRow();
            if (response.Data != null)
            {
                list = HelperMethods.ChangeModelTypeToCustomerOrderDataGridModel(response.Data);
                dataGridView1.DataSource = list;
                dataGridView1.Columns[0].HeaderText = "Sipariş Id";
                dataGridView1.Columns[1].HeaderText = "Müşteri Adı";
                dataGridView1.Columns[2].HeaderText = "Ürün Adı";
                dataGridView1.Columns[3].HeaderText = "Ürün Miktarı";
                dataGridView1.Columns[4].HeaderText = "Ürün Birim Fiyatı(TL)";
                dataGridView1.Columns[5].HeaderText = "Toplam Kdv Tutarı(TL)";
                dataGridView1.Columns[6].HeaderText = "Toplam Tutar(TL)";
                dataGridView1.Columns[7].HeaderText = "Sipariş Durumu";
                dataGridView1.Columns[8].HeaderText = "Sipariş Tarihi";
            }
        }

        private void LastOrders_Load(object sender, EventArgs e)
        {
            Task bindData = BindData();
        }

        private void return_btn_Click(object sender, EventArgs e)
        {
            _prev.Show();
            this.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var orderId = (int)(sender as DataGridView).Rows[e.RowIndex].Cells[0].Value; // Detayı görülmek istenen verinin ıd değerini alıyoruz.
            var formonSiprarisDetay = _serviceProvider.GetRequiredService<OnSiprarisDetay>();
            formonSiprarisDetay._customerOrderDataGridModel = list.FirstOrDefault(x => x.Id == orderId); // tüm detay verilerini çekiyoruz.
            formonSiprarisDetay.BindData();
        }
    }
}

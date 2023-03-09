using BusinessManagementApp.Common.Enums;
using BusinessManagementApp.UI.Helpers;
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
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace BusinessManagementApp.UI.Forms
{
    public partial class SiparisIslemleri : Form, INodeable
    {
        public Form _prev { get; set; }
        readonly IServiceProvider _serviceProvider;
        readonly ICustomerOrderService _customerOrderService;
        List<CustomerOrderDataGridModel> list = new List<CustomerOrderDataGridModel>();

        public SiparisIslemleri(ICustomerOrderService customerOrderService, IServiceProvider serviceProvider)
        {
            _customerOrderService = customerOrderService;
            _serviceProvider = serviceProvider;
            InitializeComponent();
            this.Show();
        }

        private void return_btn_Click(object sender, EventArgs e)
        {
            _prev.Show();
            this.Close();
        }

        private void SiparisIslemleri_FormClosed(object sender, FormClosedEventArgs e)
        {
            _prev.Close(); //it's working
        }
        public List<CustomerOrderDataGridModel> ChangeModelType(List<CustomerOrderListDto> CustomerOrderLists)
        {
            list = new List<CustomerOrderDataGridModel>();
            foreach (var item in CustomerOrderLists)
            {
                list.Add(new()
                {
                    Id = item.Id,
                    Amount = item.Amount,
                    CustomerName = item.Customer.CominicatePersonName + " -- " + item.Customer.CompanyName,
                    Date = item.Date,
                    OrderStatus = "Ön Sipariş",
                    ProductName = item.Product.Name,
                    TotalKdvPrice = item.KdvPrice.GetDoubleMoneyFormat(),
                    TotalPrice = item.TotalPrice.GetDoubleMoneyFormat(),
                    UnitPrice = item.UnitPrice.GetDoubleMoneyFormat()
                });
            }
            return list;
        }
        public async Task AllProduct()
        {
            var response = await _customerOrderService.GetIncludedAll(x=>x.IsActive == true && x.OrderStatusTypeId == (int)OrderStatusType.PreOrder,true);
            response.Data.OrderByDescending(x => x.Date);
            if (response.Data != null)
            {
                dataGridView1.DataSource = ChangeModelType(response.Data);
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
            dataGridView1.ReadOnly = true;
            //dataGridView1.ForeColor= Color.Yellow;
        }

        private void SiparisIslemleri_Load(object sender, EventArgs e)
        {
            Task bindProducts = AllProduct();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var orderId = (int)(sender as DataGridView).Rows[e.RowIndex].Cells[0].Value;
            var formonSiprarisDetay = _serviceProvider.GetRequiredService<OnSiprarisDetay>();
            formonSiprarisDetay._customerOrderDataGridModel = list.FirstOrDefault(x=>x.Id == orderId);
            formonSiprarisDetay.BindData(); //müq
        }
    }
}

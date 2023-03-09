using BusinessManagementApp.UI.Helpers;
using BusinessManagementApp.UI.Helpers.Models;
using BussinesManagementApp.Bussines.Interfaces;
using BussinesManagementApp.Dtos;
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
    public partial class OnSiprarisDetay : Form
    {
        readonly ICustomerOrderService _customerOrderService;
        public CustomerOrderDataGridModel _customerOrderDataGridModel;
        public OnSiprarisDetay(ICustomerOrderService customerOrderService)
        {
            _customerOrderService = customerOrderService;
            InitializeComponent();
            this.Show();
        }
        public async Task ComplatePreOrder()
        {
           var response = await _customerOrderService.ComplatePreOrderAndUpdateWarehouse(_customerOrderDataGridModel.Id);
            MessageBox.Show(response.Message);
        }
        private void PreOrderComplate_btn_Click(object sender, EventArgs e)
        {
            Task complateOrder = ComplatePreOrder();
        }
        public void BindData()
        {
            Amount_txt.Text = _customerOrderDataGridModel.Amount.ToString();
            CustomerName_txt.Text = _customerOrderDataGridModel.CustomerName;
            Date_txt.Text = _customerOrderDataGridModel.Date.ToString();
            KdvPrice_txt.Text = _customerOrderDataGridModel.TotalKdvPrice.GetStringMoneyFormat();
            SiparisTuru_txt.Text = _customerOrderDataGridModel.OrderStatus;
            TotalPrice_txt.Text = _customerOrderDataGridModel.TotalPrice.GetStringMoneyFormat();
            UnitPrice_txt.Text = _customerOrderDataGridModel.TotalPrice.GetStringMoneyFormat();
            UrunAdı_txt.Text = _customerOrderDataGridModel.ProductName.ToString();
        }

        private void close_BTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

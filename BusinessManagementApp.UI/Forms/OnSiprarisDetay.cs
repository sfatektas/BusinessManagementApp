﻿using BusinessManagementApp.Common.Enums;
using BusinessManagementApp.UI.Helpers;
using BusinessManagementApp.UI.Helpers.Models;
using BusinessManagementApp.UI.Interfaces;
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

        public SiparisIslemleri _prev { get; set; }

        public OnSiprarisDetay(ICustomerOrderService customerOrderService)
        {
            _customerOrderService = customerOrderService;
            InitializeComponent();
            this.Show();
        }
        public async Task ComplatePreOrder()
        {
            try
            {
                var response = await _customerOrderService.ComplatePreOrderAndUpdateWarehouse(_customerOrderDataGridModel.Id);
                if (response.ResponseType == ResponseType.Success)
                    await _prev.AllProduct(); // İşlem onaylanırsa bekleyen siparişleri güncelle
                MessageBox.Show(response.Message);
                //TODO ön sipariş geçerken stoktaki ürünün miktarı azalıyor ürünü tamamlayınca gene miktar azalıyor ??
            }
            catch (Exception e)
            {
                MessageBox.Show("Hata durumu : "+e.Message);
            }

        }
        private void PreOrderComplate_btn_Click(object sender, EventArgs e)
        {
            Task complateOrder = ComplatePreOrder();
        }
        public void BindData()
        {
            if(_customerOrderDataGridModel.OrderStatusId == (int)OrderStatusType.Complated)
                PreOrderComplate_btn.Enabled = false;
            Amount_txt.Text = _customerOrderDataGridModel.Amount.ToString();
            CustomerName_txt.Text = _customerOrderDataGridModel.CustomerName;
            Date_txt.Text = _customerOrderDataGridModel.Date.ToString();
            KdvPrice_txt.Text = _customerOrderDataGridModel.TotalKdvPrice.GetStringMoneyFormat();
            SiparisTuru_txt.Text = _customerOrderDataGridModel.OrderStatus;
            TotalPrice_txt.Text = _customerOrderDataGridModel.TotalPrice.GetStringMoneyFormat();
            UnitPrice_txt.Text = _customerOrderDataGridModel.UnitPrice.GetStringMoneyFormat();
            UrunAdı_txt.Text = _customerOrderDataGridModel.ProductName.ToString();
        }

        private void close_BTN_Click(object sender, EventArgs e)
        {
            if(_prev!=null)
                _prev.Show();
            this.Close();
        }
    }
}

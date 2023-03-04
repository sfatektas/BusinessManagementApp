using BusinessManagementApp.Common;
using BusinessManagementApp.Common.Enums;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BusinessManagementApp.UI.Forms
{
    public partial class TedarikciIslemler : Form, INodeable
    {
        public Form _prev { get; set; }
        readonly ISupplierService _supplierService;

        public TedarikciIslemler(ISupplierService supplierService) //TODO service implemente ediceleck
        {
            _supplierService = supplierService;
            InitializeComponent();
            this.Show();
        }

        public async Task ComboboxItemLoad()
        {
            var response = await _supplierService.GetAllAsync(x=>x.IsActive ==true);
            if (response.ResponseType == ResponseType.Success)
            {
                var items = new List<ComboboxModel>() { };
                foreach (var item in response.Data)
                {
                    items.Add(new() { Text = item.Info, Value = item.Id });
                }
                HelperMethods.ComboboxListBindToCombobox(items, new List<System.Windows.Forms.ComboBox>() { comboboxUpdate });
            }

        }
        private void TedarikciIslemler_Load(object sender, EventArgs e)
        {
            groupBox4.Visible= false;
            Task ItemLoad = ComboboxItemLoad();
        }

        private void Ekle(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            _prev.Show();
            this.Dispose();
        }
        public async Task AddSupplier()
        {
            var response = await _supplierService.CreateAsync(new SupplierCreateDto
            {
                TelNo = TelNo_txtbox.Text,
                CominicatePersonName = ContactPerson_txtbox.Text,
                Email = Email_txtbox.Text,
                Info = companyName_txtbox.Text,
                LogisticsCompany = LogisticCompany_txtbox.Text,
            });
            if (response.ResponseType == ResponseType.ValidationError)
            {

                HelperMethods.ShowErrors(response.ValidationErrors);
                return;
            }
            MessageBox.Show(response.Message);
        }
        public async Task UpdateTxtBind(int id = 0 , string telno ="")
        {
            if (id != 0)
            {
                var response = await _supplierService.GetByIdAsync(id);
                if (response.ResponseType == ResponseType.Success)
                {
                    companyInfoupdate_txt.Text = response.Data.Info;
                    contactnameupdate_txt.Text = response.Data.CominicatePersonName;
                    telnoupdate_txt.Text = response.Data.TelNo;
                    emailUpdate_txt.Text = response.Data.Email;
                    LogisticCompany_txt.Text = response.Data.LogisticsCompany;
                }
            }
            else
            {
                var response2 = await _supplierService.GetByFilterAsync(x=>x.TelNo == telno);
                if (response2.ResponseType == ResponseType.Success)
                {
                   var data =  response2.Data;
                    companyInfoupdate_txt.Text = data.Info;
                    contactnameupdate_txt.Text = data.CominicatePersonName;
                    telnoupdate_txt.Text = data.TelNo;
                    emailUpdate_txt.Text = data.Email;
                    LogisticCompany_txt.Text = data.LogisticsCompany;
                }
            }

        }
        private void SupplierAdd_btn_Click(object sender, EventArgs e)
        {
            Task addSupplier = AddSupplier();

        }

        private void comboboxUpdate_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Task bindTxtUpdate = UpdateTxtBind((int)comboboxUpdate.SelectedValue);
            groupBox4.Visible = false ? true : true;

        }

        private void TelNoSearchBtnUpdate_btn_Click(object sender, EventArgs e)
        {
            Task findtxtUpdate = UpdateTxtBind(0, TelnoUpdateSearch_txt.Text);
        }

        private void returnBtnClick(object sender, EventArgs e)
        {
            _prev.Show();
            this.Close();
        }
    }
}

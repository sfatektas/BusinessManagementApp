using BusinessManagementApp.Common.Enums;
using BusinessManagementApp.UI.Helpers.Models;
using BusinessManagementApp.UI.Helpers;
using BussinesManagementApp.Bussines.Interfaces;
using BussinesManagementApp.Bussines.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using BussinesManagementApp.Dtos;

namespace BusinessManagementApp.UI.Forms
{
    public partial class MusteriEkle : Form
    {
        readonly ICustomerService _customerService;
        public UrunSat _prev { get; set; }
        public MusteriEkle(ICustomerService customerService)
        {
            _customerService = customerService;
            InitializeComponent();
            HelperMethods.DisableTextBox(new() { companyNameAdd_txt, TaxNoAdd_txt, TradeRegisterNoAdd_txt });
            this.Show();
        }

        private void Close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MusteriEkle_Load(object sender, EventArgs e)
        {
            var models = new List<ComboboxModel>() {
                new ComboboxModel() { Text = "Şahıs", Value = (int)CustomerType.Single},
                new ComboboxModel() { Text = "Tüzel ", Value = (int)CustomerType.Corporate},
            };
            HelperMethods.ComboboxListBindToCombobox(models, new List<ComboBox> { comboBoxAdd_customerTypes });
        }

        private void comboBoxAdd_customerTypes_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if ((int)comboBoxAdd_customerTypes.SelectedValue == (int)CustomerType.Corporate &&
                (int)comboBoxAdd_customerTypes.SelectedValue !=0 )
            {
                companyNameAdd_txt.Enabled = true;
                TaxNoAdd_txt.Enabled = true;
                TradeRegisterNoAdd_txt.Enabled = true;
            }
            else
            {
                HelperMethods.ClearTextBox(new() { companyNameAdd_txt, TaxNoAdd_txt, TradeRegisterNoAdd_txt, CominicationNameAdd_txt, EmailAdd_txt, TelNoAdd_txt });
                HelperMethods.DisableTextBox(new() { companyNameAdd_txt, TaxNoAdd_txt, TradeRegisterNoAdd_txt });
            }
        }
        public async Task AddCustomer()
        {
            if (HelperMethods.IsNotNull(new List<TextBox> { CominicationNameAdd_txt, EmailAdd_txt, TelNoAdd_txt }) && (int)comboBoxAdd_customerTypes.SelectedValue != 0)
            {
                var response = await _customerService.CreateAsync(new CustomerCreateDto()
                {
                    CominicatePersonName = CominicationNameAdd_txt.Text,
                    CustomerTypeId = (int)comboBoxAdd_customerTypes.SelectedValue,
                    Email = EmailAdd_txt.Text,
                    TelNo = TelNoAdd_txt.Text,
                    CompanyName = companyNameAdd_txt.Text,
                    TaxNo = TaxNoAdd_txt.Text,
                    TradeRegisterNumber = TradeRegisterNoAdd_txt.Text
                });
                if (response.ResponseType == ResponseType.ValidationError)
                {
                    HelperMethods.ShowErrors(response.ValidationErrors);
                }
                else
                    MessageBox.Show(response.Message);
                HelperMethods.ClearTextBox(new List<TextBox>() { CominicationNameAdd_txt, EmailAdd_txt, TelNoAdd_txt, companyNameAdd_txt, TaxNoAdd_txt, TradeRegisterNoAdd_txt });
                await _prev.ComboboxCustomersItemLoad();
            }
            else
                MessageBox.Show("Gerekli alanları seçiniz/doldurunuz.");
        }
        private void CustomerAdd_btn_Click(object sender, EventArgs e)
        {
            Task addcustomer = AddCustomer();
        }
    }
}

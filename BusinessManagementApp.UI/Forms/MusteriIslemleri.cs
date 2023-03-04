﻿using AutoMapper;
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
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessManagementApp.UI.Forms
{
    public partial class MusteriIslemleri : Form, INodeable
    {
        public Form _prev { get; set; }
        readonly IMapper _mapper;
        private CustomerUpdateDto willUpdateDto;
        readonly IServiceProvider _serviceProvider;
        public ICustomerService _customerService;
        public MusteriIslemleri(ICustomerService customerService, IMapper mapper, IServiceProvider serviceProvider)
        {
            _customerService = customerService;
            InitializeComponent();
            this.Show();
            _mapper = mapper;
            _serviceProvider = serviceProvider;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_TextChanged(object sender, EventArgs e)
        {

        }
        public async Task RefReshCombobox()
        {
            var comboboxmodels = new List<ComboboxModel>();
            var response = await _customerService.GetAllAsync();
            foreach (var item in response.Data)
            {
                comboboxmodels.Add(new ComboboxModel { Text = item.CominicatePersonName + " " + item.CompanyName, Value = item.Id });
            }
            HelperMethods.ComboboxListBindToCombobox(comboboxmodels, new List<ComboBox> { comboBoxFindUpdate });
        }
        private void MusteriIslemleri_Load(object sender, EventArgs e)
        {
            Task refresh = RefReshCombobox();
            groupBoxUpdate.Enabled = false;

            var models = new List<ComboboxModel>() {
                new ComboboxModel() { Text = "Şahıs", Value = (int)CustomerType.Single},
                new ComboboxModel() { Text = "Tüzel ", Value = (int)CustomerType.Corporate},
            };
            HelperMethods.ComboboxListBindToCombobox(models, new List<ComboBox> { comboBoxAdd_customerTypes });
        }

        private void comboBoxAdd_customerTypes_SelectionChangeCommitted(object sender, EventArgs e)
        {
            HelperMethods.EnableTextBox(new List<TextBox>() { TaxNoAdd_txt, companyNameAdd_txt, TradeRegisterNoAdd_txt });

            if ((int)comboBoxAdd_customerTypes.SelectedValue == (int)CustomerType.Single)
            {
                HelperMethods.DisableTextBox(new List<TextBox>() { TaxNoAdd_txt, companyNameAdd_txt, TradeRegisterNoAdd_txt });
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
            }
            else
                MessageBox.Show("Gerekli alanları seçiniz/doldurunuz.");
        }
        private void CustomerAdd_btn_Click(object sender, EventArgs e)
        {

            Task customerAdd = AddCustomer();
            Task refreshCombobox = RefReshCombobox();
        }

        private void comboBoxFindUpdate_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Task bindingData = bindTxtData();
            groupBoxUpdate.Enabled = true;

        }
        public async Task bindTxtData(string telno = "")
        {
            HelperMethods.EnableTextBox(new List<TextBox> { companyNameUpdate_txt, taxnoUpdate_txt, TradeRegNoUpdate_txt });
            var response = (telno =="")
                ? await _customerService.GetByFilterAsync(x => x.Id == (int)comboBoxFindUpdate.SelectedValue) 
                : await _customerService.GetByFilterAsync(x=>x.TelNo == telno);
            willUpdateDto = _mapper.Map<CustomerUpdateDto>(response.Data);

            contactPersonNameUpdate_txt.Text = response.Data.CominicatePersonName;
            emailUpdate_txt.Text = response.Data.Email;
            telnoUpdate_txt.Text = response.Data.TelNo;

            if (response.Data.CustomerTypeId == (int)CustomerType.Single)
            {
                HelperMethods.DisableTextBox(new List<TextBox> { companyNameUpdate_txt, TradeRegNoUpdate_txt, taxnoUpdate_txt });
            }
            else
            {
                companyNameUpdate_txt.Text = response.Data.CompanyName;
                taxnoUpdate_txt.Text = response.Data.TaxNo;
                TradeRegNoUpdate_txt.Text = response.Data.TradeRegisterNumber;
            }
        }

        private void return_btn_Click(object sender, EventArgs e)
        {
            _prev.Show();
            this.Dispose();
        }

        private void CustomerUpdate_Btn_Click(object sender, EventArgs e)
        {
            willUpdateDto.CominicatePersonName = contactPersonNameUpdate_txt.Text;
            willUpdateDto.Email = emailUpdate_txt.Text;
            willUpdateDto.TelNo = telnoUpdate_txt.Text;
            if(willUpdateDto.CustomerTypeId == (int )CustomerType.Corporate) {
                willUpdateDto.CompanyName = companyNameUpdate_txt.Text;
                willUpdateDto.TaxNo = taxnoUpdate_txt.Text;
                willUpdateDto.TradeRegisterNumber = TradeRegNoUpdate_txt.Text;
            }
            Task update = UpdateData();
        }
        public async Task UpdateData()
        {
            var response = await _customerService.UpdateAsync(willUpdateDto);
            if (response.ResponseType == ResponseType.ValidationError)
            {
                HelperMethods.ShowErrors(response.ValidationErrors);
            }
            MessageBox.Show(response.Message);

        }

        private void UpdateCustomerFind_txt_Click(object sender, EventArgs e)
        {
            Task FindDto = bindTxtData(UpdateTelno_txt.Text);
        }

        private void mainmenu_btn_Click(object sender, EventArgs e)
        {
            _serviceProvider.GetRequiredService<AnaMenu>();   
        }
    }
}

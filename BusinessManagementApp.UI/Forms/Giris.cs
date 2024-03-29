﻿using BusinessManagementApp.Common.Enums;
using BussinesManagementApp.Bussines.Services;
using BussinesManagementApp.Dtos;
using Microsoft.Extensions.DependencyInjection;

namespace BusinessManagementApp.UI
{
    public partial class Giris : Form
    {
        readonly IdentityService _identityService;
        readonly IServiceProvider _serviceProvider;

        public Giris(IdentityService identityService,IServiceProvider serviceProvider)
        {
            _identityService = identityService;
            _serviceProvider = serviceProvider;
            InitializeComponent();

        }
        public async Task Login(string username , string password)
        {
            var response = await _identityService.LoginCheck(new AppUserLoginModel { Username = username, Password = password });
            if (response.ResponseType == ResponseType.Success)
            {
                //logic 
                MessageBox.Show("Giriş Başarılı");
                var form = _serviceProvider.GetRequiredService<AnaMenu>();
                form._prev = this;
                this.Hide();
            }
            else
            {
                MessageBox.Show(response.Message);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

            Task x = Login(textBox1.Text , textBox2.Text);
        }
    }
}

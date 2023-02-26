using Accessibility;
using BusinessManagementApp.Common.Enums;
using BussinesManagementApp.Bussines.Services;
using BussinesManagementApp.Dtos;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessManagementApp.UI
{
    public partial class Form1 : Form
    {
        readonly IdentityService _identityService;

        public Form1(IdentityService identityService)
        {
            _identityService = identityService;
            InitializeComponent();

        }
        private void Form1_Load(object sender, EventArgs e)
        {


        }
        public async Task Login(string username , string password)
        {
            var user = new BussinessManagementApp.Entities.IdentityEntities.AppUser()
            {
                UserName = "Admin",
                Email = "admin@gmail.com"
            };
            //password Admin123
            var response = await _identityService.LoginCheck(new AppUserLoginModel { Username = username, Password = password });
            if (response.ResponseType == ResponseType.Success)
            {
                //logic 
                MessageBox.Show("Giriş Başarılı");
                var form2 = new Form2();
                form2.Show();
                this.Close();
                
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

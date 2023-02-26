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
        public async Task doit()
        {
            var user = new BussinessManagementApp.Entities.IdentityEntities.AppUser()
            {
                UserName = "Admin",
                Email = "admin@gmail.com"
            };
            //var result = await _identityService.CreateAsync(user);
            //var resultPassword = await _identityService.AddPasswordAsync(user, "Admin123");
            var result = await _identityService.CheckPasswordAsync(user, "Admin1234");
            var x = 10;
        }
        private void button1_Click(object sender, EventArgs e)
        {

            Task x = doit();
        }
    }
}

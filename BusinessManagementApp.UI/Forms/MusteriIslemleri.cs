using BusinessManagementApp.UI.Interfaces;
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
    public partial class MusteriIslemleri : Form , INodeable
    {
        public Form _prev { get; set; }

        public MusteriIslemleri()
        {
            InitializeComponent();
            this.Show();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_TextChanged(object sender, EventArgs e)
        {

        }

        private void MusteriIslemleri_Load(object sender, EventArgs e)
        {

        }
    }
}

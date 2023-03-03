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
    public partial class UrunIslemleri : Form, INodeable
    {
        public UrunIslemleri()
        {
            InitializeComponent();
            this.Show();
        }

        public Form _prev { get; set; }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

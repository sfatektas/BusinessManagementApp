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
    public partial class DepodakiUrunler : Form , INodeable
    {
        public DepodakiUrunler()
        {
            InitializeComponent();
            this.Show();
        }

        public Form _prev { get; set; }

        private void DepodakiUrunler_Load(object sender, EventArgs e)
        {

        }


        private void TurnBack_btn_Click(object sender, EventArgs e)
        {
            _prev.Show();
            this.Close();
        }
    }
}

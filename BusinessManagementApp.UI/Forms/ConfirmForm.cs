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
    public partial class ConfirmForm : Form
    {
        public Form _confirmForm { get; set; }
        public ConfirmForm()
        {
            InitializeComponent();
        }

        private void Yes_btn_Click(object sender, EventArgs e)
        {
            //_confirmForm.ok
        }

        private void No_btn_Click(object sender, EventArgs e)
        {

        }
    }
}

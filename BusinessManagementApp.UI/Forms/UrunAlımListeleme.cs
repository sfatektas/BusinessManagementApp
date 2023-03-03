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
    public partial class UrunAlımListeleme : Form, INodeable
    {
        public UrunAlımListeleme()
        {
            InitializeComponent();
            this.Show();
        }
        public Form _prev
        {
            get; set;
        }
    }
}

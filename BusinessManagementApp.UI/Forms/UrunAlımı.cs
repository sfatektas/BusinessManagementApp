﻿using BusinessManagementApp.UI.Interfaces;
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
    public partial class UrunAlımı : Form , INodeable
    {
        
        public UrunAlımı()
        {

            InitializeComponent();
            this.Show();
        }

        public Form _prev { get; set; }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void UrunAlımı_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            _prev.Show();
        }
    }
}

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
    public partial class TedarikciEkle : Form , INodeable
    {
        public TedarikciEkle()
        {
            InitializeComponent();
            this.Show();
        }

        public Form _prev { get; set; }
    }
}

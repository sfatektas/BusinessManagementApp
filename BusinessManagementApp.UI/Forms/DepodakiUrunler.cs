using BusinessManagementApp.UI.Interfaces;
using BussinesManagementApp.Bussines.Interfaces;
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
        readonly IWarehouseService _warehouseService;

        public DepodakiUrunler(IWarehouseService warehouseService)
        {
            _warehouseService = warehouseService;
        }

        public DepodakiUrunler()
        {
            InitializeComponent();
            this.Show();
        }

        public Form _prev { get; set; }

        public async Task AllProduct()
        {
            var response = await _warehouseService.GetAllAsync();
            if (response != response.Data)
            {
                dataGridView1.DataSource= response.Data;
            }
        }
        private void DepodakiUrunler_Load(object sender, EventArgs e)
        {
            Task warehouseProducts = AllProduct();
        }


        private void TurnBack_btn_Click(object sender, EventArgs e)
        {
            _prev.Show();
            this.Close();
        }
    }
}

using BusinessManagementApp.Common.Enums;
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
using System.Windows.Forms.VisualStyles;

namespace BusinessManagementApp.UI.Forms
{
    public partial class DepodakiUrunDetay : Form
    {
        readonly IWarehouseProductService _warehouseProductService;
        public int ProductId { get; set; }
        public DepodakiUrunDetay(IWarehouseProductService warehouseProductService)
        {
            _warehouseProductService = warehouseProductService;
            InitializeComponent();
            this.Show();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        public async Task GetData()
        {
            var response = await _warehouseProductService.GetIncludedById(this.ProductId,true);
            if (response.ResponseType == ResponseType.NotFound)
            {
                MessageBox.Show("Herhangi bir data bulunamadı");
            }
            else
            {
                Meşei_txt.Text = response.Data.Product.Origin;
                SatısFiyatı_txt.Text = response.Data.Product.UnitPrice.ToString();
                StokAdedi_txt.Text = response.Data.Amount.ToString();
                Tedarikci_txt.Text = response.Data.Product.Supplier.Info.ToString();
                UrunAdı_txt.Text = response.Data.Product.Name.ToString();
            }
        }
        private void DepodakiUrunDetay_Load(object sender, EventArgs e)
        {
        }

        private void close_BTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

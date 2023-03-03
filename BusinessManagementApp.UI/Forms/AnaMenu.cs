using BusinessManagementApp.UI.Forms;
using Microsoft.Extensions.DependencyInjection;
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
    public partial class AnaMenu : Form
    {
        readonly IServiceProvider _serviceProvider;
        public AnaMenu(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
        }

        private void CustomerTransactionsBtn_Click(object sender, EventArgs e)
        {
            var musteriIslemleriform = _serviceProvider.GetRequiredService<MusteriIslemleri>();
            musteriIslemleriform._prev = this;
            this.Hide();
        }

        private void SupplierTransactions_btn(object sender, EventArgs e)
        {
            var tedarikciIslemleriform = _serviceProvider.GetRequiredService<TedarikciIslemler>();
            tedarikciIslemleriform._prev = this;
            this.Hide();
        }

        private void ProductTaken_Click(object sender, EventArgs e)
        {
            var urunalımıform = _serviceProvider.GetRequiredService<UrunAlımı>();
            urunalımıform._prev = this;
            this.Hide();
        }

        private void ProductSell_btn_Click(object sender, EventArgs e)
        {
            var urunsatısform = _serviceProvider.GetRequiredService<UrunSat>();
            urunsatısform._prev = this;
            this.Show();
        }

        private void ProductEdit_btn_Click(object sender, EventArgs e)
        {
            var urunduzenlemeform = _serviceProvider.GetRequiredService<UrunIslemleri>();
            urunduzenlemeform._prev = this;
            this.Hide();
        }

        private void WarehouseProduct_btn_Click(object sender, EventArgs e)
        {
            var stoktakiurunlerform = _serviceProvider.GetRequiredService<DepodakiUrunler>();
            stoktakiurunlerform._prev = this;
            this.Hide();
        }

        private void CreateReport_Btn_Click(object sender, EventArgs e)
        {
            var raporolusturform = _serviceProvider.GetRequiredService<RaporOlustur>();
            raporolusturform._prev = this;
            this.Hide();
        }
    }
}

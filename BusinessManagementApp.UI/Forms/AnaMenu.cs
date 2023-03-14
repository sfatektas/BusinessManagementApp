using BusinessManagementApp.UI.Forms;
using BusinessManagementApp.UI.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace BusinessManagementApp.UI
{
    public partial class AnaMenu : Form, INodeable
    {
        readonly IServiceProvider _serviceProvider;

        public Form _prev { get; set; }

        public AnaMenu(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            InitializeComponent();
            this.Show();
        }

        private void CustomerTransactionsBtn_Click(object sender, EventArgs e)
        {
            var musteriIslemleriform = _serviceProvider.GetRequiredService<MusteriIslemleri>();
            musteriIslemleriform._prev = this;
            //this.Hide();
        }

        private void SupplierTransactions_btn(object sender, EventArgs e)
        {
            var tedarikciIslemleriform = _serviceProvider.GetRequiredService<TedarikciIslemler>();
            tedarikciIslemleriform._prev = this;
            //this.Hide();
        }

        private void ProductTaken_Click(object sender, EventArgs e)
        {
            var urunalımıform = _serviceProvider.GetRequiredService<UrunAlımı>();
            urunalımıform._prev = this;
            //this.Hide();
        }

        private void ProductSell_btn_Click(object sender, EventArgs e)
        {
            var urunsatısform = _serviceProvider.GetRequiredService<UrunSat>();
            urunsatısform._prev = this;
            //this.Hide();
        }

        private void ProductEdit_btn_Click(object sender, EventArgs e)
        {
            var urunduzenlemeform = _serviceProvider.GetRequiredService<UrunIslemleri>();
            urunduzenlemeform._prev = this;
            //this.Hide();
        }

        private void WarehouseProduct_btn_Click(object sender, EventArgs e)
        {
            var stoktakiurunlerform = _serviceProvider.GetRequiredService<DepodakiUrunler>();
            stoktakiurunlerform._prev = this;
            //this.Hide();
        }

        private void CreateReport_Btn_Click(object sender, EventArgs e)
        {
            var raporolusturform = _serviceProvider.GetRequiredService<RaporOlustur>();
            raporolusturform._prev = this;
            //this.Hide();
        }

        private void PreOreder_btn_Click(object sender, EventArgs e)
        {
            var onsiparislerform = _serviceProvider.GetRequiredService<SiparisIslemleri>();
            onsiparislerform._prev = this;
            //this.Hide();
        }

        private void LastOrder_btn_Click(object sender, EventArgs e)
        {
            var urunduzenlemeform = _serviceProvider.GetRequiredService<LastOrders>();
            urunduzenlemeform._prev = this;
        }

        private void AnaMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            _prev.Close();
        }
    }
}

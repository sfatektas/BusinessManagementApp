using BusinessManagementApp.UI.Interfaces;

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
        //TODO buttonlardaki yönlendirmelere baK , textboxlardaki verileri hata almayacak şekilde bind et , Raporlama yap deneme yap
    }
}

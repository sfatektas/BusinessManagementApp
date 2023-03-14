using BusinessManagementApp.Common.Enums;
using BusinessManagementApp.UI.Helpers;
using BusinessManagementApp.UI.Interfaces;
using BussinesManagementApp.Bussines.Interfaces;
using BussinesManagementApp.Dtos;

namespace BusinessManagementApp.UI.Forms
{
    public partial class TedarikciEkle : Form 
    {
        public ISupplierService _supplierService;
        public UrunEkle _prev { get; set; }

        public TedarikciEkle(ISupplierService supplierService)
        {
            _supplierService = supplierService;
            InitializeComponent();
            this.Show();
        }
        public async Task AddSupplier()
        {
            var response = await _supplierService.CreateAsync(new SupplierCreateDto
            {
                TelNo = TelNo_txtbox.Text,
                CominicatePersonName = ContactPerson_txtbox.Text,
                Email = Email_txtbox.Text,
                Info = companyName_txtbox.Text,
                LogisticsCompany = LogisticCompany_txtbox.Text,
            });
            if (response.ResponseType == ResponseType.ValidationError)
            {
                HelperMethods.ShowErrors(response.ValidationErrors);
                return;
            }
            else
            {
                MessageBox.Show(response.Message);
                await _prev.ComboboxItemLoad();
                this.Close();
            }
        }

        private void Close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SupplierAdd_btn_Click(object sender, EventArgs e)
        {
            Task addSupplier = AddSupplier();
        }
        //TODO buttonlardaki yönlendirmelere baK , textboxlardaki verileri hata almayacak şekilde bind et , Raporlama yap deneme yap
    }
}

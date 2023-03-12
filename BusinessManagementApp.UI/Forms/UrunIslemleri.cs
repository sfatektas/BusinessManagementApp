using BusinessManagementApp.Common.Enums;
using BusinessManagementApp.UI.Helpers.Models;
using BusinessManagementApp.UI.Helpers;
using BusinessManagementApp.UI.Interfaces;
using BussinesManagementApp.Bussines.Interfaces;
using BussinesManagementApp.Dtos;
using AutoMapper;

namespace BusinessManagementApp.UI.Forms
{
    public partial class UrunIslemleri : Form, INodeable
    {
        readonly IProductService _proudctService;
        readonly ISupplierService _supplierService;
        ProductUpdateDto _productUpdateDto;
        readonly IMapper _mapper;
        public UrunIslemleri(IProductService proudctService, ISupplierService supplierService, IMapper mapper)
        {
            _supplierService = supplierService;
            _proudctService = proudctService;
            _mapper = mapper;
            InitializeComponent();
            this.Show();
        }

        public Form _prev { get; set; } // bir önceki formun referansını tutuyorum


        private void UrunIslemleri_Load(object sender, EventArgs e)
        {
            //Task getallproduct = ComboboxItemLoad();
            Task getallsupplierandproduct = ComboboxSupplierAndProductItemLoad();
        }
        public async Task ComboboxSupplierAndProductItemLoad()
        {
            var response = await _supplierService.GetAllAsync(x => x.IsActive == true);
            if (response.ResponseType == ResponseType.Success)
            {
                var items = new List<ComboboxModel>() { };
                foreach (var item in response.Data)
                {
                    items.Add(new() { Text = item.Info, Value = item.Id });
                }
                HelperMethods.ComboboxListBindToCombobox(items, new List<ComboBox>() { SupplierSellect_combobox, SelectSupplierUpdate_cbmx });
                // ayrı Task içerisinde olduğu zaman alt alta kullanımı hata yarattı.
            }
            var response2 = await _proudctService.GetAllAsync(x => x.IsActive == true);
            if (response2.ResponseType == ResponseType.Success)
            {
                var items = new List<ComboboxModel>() { };
                foreach (var item in response2.Data)
                {
                    items.Add(new() { Text = item.Name, Value = item.Id });
                }
                HelperMethods.ComboboxListBindToCombobox(items, new List<ComboBox>() { SelectProductUpdateCombobox });
            }
        }
        public async Task GetByIdProductToBindTextBox(int id = 0)
        {
            var productId = id==0 ? (int)SelectProductUpdateCombobox.SelectedValue :id;
            var response = await _proudctService.GetByFilterAsync(x=>x.Id==productId);
            if (response.ResponseType == ResponseType.Success)
            {
                groupBox3.Visible = true; // ilgili ürün var ise görünür yap
                _productUpdateDto = _mapper.Map<ProductUpdateDto>(response.Data); // seçilen ıd ye ait datayı local değişkende tutuyorum

                SelectSupplierUpdate_cbmx.SelectedValue = response.Data.SupplierId;
                UpdateOrigin_txt.Text = response.Data.Origin;
                UpdateProductName_txt.Text = response.Data.Name;
                UnitPriceUpdate_txt.Text = response.Data.UnitPrice.ToString();
            }
            else
                MessageBox.Show("Bu id değerine sahip ürün bulunmamaktadır.");
        }

        private void return_btn_Click(object sender, EventArgs e)
        {
            _prev.Show();
            this.Dispose();
        }
        public async Task UpdateProduct()
        {
            try
            {
                _productUpdateDto.Origin = UpdateOrigin_txt.Text;
                _productUpdateDto.UnitPrice = double.Parse(UnitPriceUpdate_txt.Text);
                _productUpdateDto.Name = UpdateProductName_txt.Text;
                _productUpdateDto.SupplierId = (int)SelectSupplierUpdate_cbmx.SelectedValue;
                
                var response = await _proudctService.UpdateAsync(_productUpdateDto);
                if (response.ResponseType == ResponseType.ValidationError)
                {
                    HelperMethods.ShowErrors(response.ValidationErrors);
                }
                else if (response.ResponseType == ResponseType.Success)
                {
                    HelperMethods.ClearTextBox(new List<TextBox>() // Clear textbox.
                        {
                            UpdateOrigin_txt,
                            UpdateProductName_txt,
                            UnitPriceUpdate_txt,
                        });
                }
                MessageBox.Show(response.Message);


            }
            catch (FormatException)
            {
                MessageBox.Show("Lütfen giriş formatlarını kontrol ediniz.");
            }
            

        }

        private void Update_btn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Emin misiniz?", "Onay", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Task updateproduct = UpdateProduct();
            }
        }
        public async Task AddProduct()
        {
            var response = await _proudctService.CreateAsync(new ProductCreateDto()
            {
                Name = AddProductName_txt.Text,
                Origin = AddOrigin_txt.Text,
                SupplierId = (int)SupplierSellect_combobox.SelectedValue,
            });
            if (response.ResponseType == ResponseType.ValidationError)
            {
                HelperMethods.ShowErrors(response.ValidationErrors);
            }
            MessageBox.Show(response.Message);
            HelperMethods.ClearTextBox(new() { AddProductName_txt, AddOrigin_txt });
        }
        private void ProductAdd__Click(object sender, EventArgs e)
        {
            Task ProductAdd = AddProduct();
        }

        private void SelectProductUpdateCombobox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            groupBox3.Visible = true;
            Task binddata = GetByIdProductToBindTextBox();
        }

        private void ProductFind_btn_Click(object sender, EventArgs e)
        {
            try
            {
                Task binddata = GetByIdProductToBindTextBox(int.Parse(SelectProuductUpdate_txt.Text));
            }
            catch (Exception)
            {
                MessageBox.Show("Geçerli bir format giriniz.");
            }
        }
    }
}

using AutoMapper;
using BusinessManagementApp.Common.Enums;
using BusinessManagementApp.UI.Helpers;
using BussinesManagementApp.Bussines.Interfaces;
using BussinesManagementApp.Dtos;
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
    public partial class UrunGuncelle : Form
    {
        readonly IProductService _productService;
        readonly IMapper _mapper;
        public UrunSat _prev { get; set; } // ürünleri güncellemek için formun referansını burdada tutyorum.
        public int WillUpdateProductID { get; set; }
        ProductUpdateDto _productUpdateDto;
        public UrunGuncelle(IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
            InitializeComponent();
            this.Show();
            // Sadece Birim fiyat değiştirilebilsin.
            HelperMethods.DisableTextBox(new List<TextBox>() { UpdateOrigin_txt , UpdateProductName_txt , UpdateSelectSupplier_txt });

        }
        public async Task FindData()
        {
            var response = await  _productService.GetIncludedById(id: WillUpdateProductID);
            if (response.ResponseType == ResponseType.Success)
            {
                this.BindData(response.Data);
            }
            else
                MessageBox.Show(response.Message);
        }
        public void BindData(ProductListDto dto)
        {
            UpdateOrigin_txt.Text = dto.Origin;
            UpdateProductName_txt.Text = dto.Name;
            UpdateSelectSupplier_txt.Text = dto.Supplier.CominicatePersonName;
            UnitPriceUpdate_txt.Text = dto.UnitPrice.ToString(); // unit price alanını para değerini kontrol et
            _productUpdateDto = _mapper.Map<ProductUpdateDto>(dto);
        }
        public async Task UpdateProduct()
        {
            _productUpdateDto.UnitPrice = HelperMethods.doubleParseWithError(UnitPriceUpdate_txt.Text); 
            var response = await _productService.UpdateAsync(this._productUpdateDto);
            if(response.ResponseType == ResponseType.ValidationError)
            {
                HelperMethods.ShowErrors(response.ValidationErrors);
            }
            else
            { 
                MessageBox.Show(response.Message);
                await _prev.GetByIdProductToBindTextBox(_productUpdateDto.Id);
                this.Close();
            }

        }
        private void UnitPriceUpdate_txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            HelperMethods.IsOkPriceFormat(ref sender, e);
        }

        private void Update_btn_Click(object sender, EventArgs e)
        {
            Task UpdatProduct = UpdateProduct();
        }
    }
}

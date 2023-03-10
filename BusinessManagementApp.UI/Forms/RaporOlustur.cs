using BusinessManagementApp.Common.Enums;
using BusinessManagementApp.UI.Helpers.Models;
using BusinessManagementApp.UI.Helpers;
using BusinessManagementApp.UI.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BussinesManagementApp.Bussines.Interfaces;
using BussinesManagementApp.Dtos.ReportDtos;

namespace BusinessManagementApp.UI.Forms
{
    public partial class RaporOlustur : Form, INodeable
    {
        public Form _prev { get; set; }
        readonly ICustomerService _customerService;
        readonly IProductService _productService;
        readonly IReportService _reportService;
        ReportQueryDto _reportCreateDto = new();
        public RaporOlustur(ICustomerService customerService, IProductService productService, IReportService reportService)
        {
            _customerService = customerService;
            _productService = productService;
            _reportService = reportService;
            InitializeComponent();
            this.Show();
        }
        public async Task ComboboxCustomerItemLoad()
        {
            var response = await _customerService.GetAllAsync(x => x.IsActive == true);
            if (response.ResponseType == ResponseType.Success)
            {
                var items = new List<ComboboxModel>() { };
                foreach (var item in response.Data)
                {
                    items.Add(new() { Text = item.CominicatePersonName + " -- " +item.CompanyName, Value = item.Id });
                }
                HelperMethods.ComboboxListBindToCombobox(items, new List<System.Windows.Forms.ComboBox>() { customerSelect_cbx });
            }
        }
        public async Task ComboboxProductItemLoad()
        {
            var response = await _productService.GetAllAsync(x => x.IsActive == true);
            if (response.ResponseType == ResponseType.Success)
            {
                var items = new List<ComboboxModel>() { };
                foreach (var item in response.Data)
                {
                    items.Add(new() { Text = item.Name, Value = item.Id });
                }
                HelperMethods.ComboboxListBindToCombobox(items, new List<System.Windows.Forms.ComboBox>() { productSelect_cbx });
                await Task.CompletedTask;
            }
        }
        public void StaticComboboxItemLoad()
        {
            var ReportTyperitems = new List<ComboboxModel>() {
                new(){ Text = "Müşteri Bazlı", Value = (int)ReportType.CustomerBased},
                new(){ Text = "Ürün Bazlı", Value = (int)ReportType.ProductBased},
                new(){ Text = "Genel", Value = (int)ReportType.General},
            };
            var TimeRangeTypeItems = new List<ComboboxModel>()
            {
                new(){ Text = " Son 1 Ay", Value = (int)TimeRangeType.OneMonth},
                new(){ Text = " Son 3 Ay", Value = (int)TimeRangeType.ThreeMonth},
                new(){ Text = " Son 6 Ay", Value = (int)TimeRangeType.SixMonth},
                new(){ Text = " Son 12 Ay", Value = (int)TimeRangeType.OneYear},
            };
            HelperMethods.ComboboxListBindToCombobox(ReportTyperitems, new List<System.Windows.Forms.ComboBox>() { ReportType_cbx });
            HelperMethods.ComboboxListBindToCombobox(TimeRangeTypeItems, new List<System.Windows.Forms.ComboBox>() { timerange_cbx });
        }
        public async Task BindData()
        {
            this.StaticComboboxItemLoad();
            await ComboboxProductItemLoad();
            await ComboboxCustomerItemLoad();
        }
        private void RaporOlustur_Load(object sender, EventArgs e)
        {
            Task bindData = BindData();
        }
        public async Task WriteProductTxt()
        {
            var response = await _productService.GetByFilterAsync(x => x.Id == (int)productSelect_cbx.SelectedValue);
            SelectedProduct_txt.Text = response.Data.Name;
            _reportCreateDto.ProductId = response.Data.Id;
        }
        public async Task WriteCustomerTxt()
        {
            var response = await _customerService.GetByFilterAsync(x => x.Id == (int)customerSelect_cbx.SelectedValue);
            SelectedProduct_txt.Text = response.Data.CominicatePersonName + " -- "+response.Data.CompanyName;
            _reportCreateDto.CustomerId = response.Data.Id;
        }
        private void productSelect_cbx_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Task writeproducttxt = WriteProductTxt();
        }

        private void customerSelect_cbx_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Task writecustomertxt = WriteCustomerTxt();

        }

        private void ReportType_cbx_SelectionChangeCommitted(object sender, EventArgs e)
        {
            _reportCreateDto.ReportTypeId = (int)ReportType_cbx.SelectedValue;
        }

        private void timerange_cbx_SelectionChangeCommitted(object sender, EventArgs e)
        {
            _reportCreateDto.TimeRangeTypeId = (int)timerange_cbx.SelectedValue;
        }
        public async Task CustomerReportCreate(ReportQueryDto dto)
        {
            var response = await _reportService.GetReportResultModelForCustomer(dto);
            if (response.ResponseType == ResponseType.ValidationError)
                HelperMethods.ShowErrors(response.ValidationErrors);
            else if (response.ResponseType == ResponseType.Success)
            {
                MessageBox.Show(response.Message);
            }
            else
                MessageBox.Show(response.Message);
        }
        private void createReport_btn_Click(object sender, EventArgs e)
        {
            //_reportCreateDto.ReportTypeId = (int)ReportType_cbx.SelectedValue;
            //_reportCreateDto.TimeRangeTypeId = (int)timerange_cbx.SelectedValue;
            //switch (timerange_cbx.SelectedValue)
            //{
            //    case (int)TimeRangeType.OneMonth:
            //        _reportCreateDto.Month = 1;
            //        break;
            //    case (int)TimeRangeType.ThreeMonth:
            //        _reportCreateDto.Month = 3;
            //        break;
            //    case (int)TimeRangeType.SixMonth:
            //        _reportCreateDto.Month = 6;
            //        break;
            //    case (int)TimeRangeType.OneYear:
            //        _reportCreateDto.Month = 12;
            //        break;

            //    default:
            //        break;
            //}
            //Task createReport = CustomerReportCreate(_reportCreateDto);

            ExcelHelpers.CreateExcelFile(new());
        }
    }
}

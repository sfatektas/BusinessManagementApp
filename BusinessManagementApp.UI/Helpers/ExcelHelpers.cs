using BusinessManagementApp.Common.Enums;
using BussinesManagementApp.Dtos.ReportDtos;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessManagementApp.UI.Helpers
{
    public class ExcelHelpers
    {
        public ExcelPackage _package;
        public ExcelHelpers()
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            _package = new ExcelPackage();
        }

        public bool CreateExcelFile(ReportType reportType , ReportResultModel<ReportDataForCustomer, ReportLastResultForCustomer> customerreportResultModel =null)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (var package = new ExcelPackage())
            {
                //ExcelPackage package = new ExcelPackage();
                switch (reportType)
                {
                    case ReportType.CustomerBased:
                        #region CustomerReportExcelTransaction
                        package.Workbook.Worksheets.Add("MüşteriRapor");
                        ExcelWorksheet worksheet = package.Workbook.Worksheets.FirstOrDefault();
                        worksheet.Cells[1, 1].Value = "İletişeme geçilecek kişi";
                        worksheet.Cells[1, 1].Style.Font.Bold = true;
                        worksheet.Cells[1, 2].Value = "Ürün Adı";
                        worksheet.Cells[1, 2].Style.Font.Bold = true;
                        worksheet.Cells[1, 3].Value = "Satılan Birim Fiyat(TL)";
                        worksheet.Cells[1, 3].Style.Font.Bold = true;
                        worksheet.Cells[1, 4].Value = "Miktar";
                        worksheet.Cells[1, 4].Style.Font.Bold = true;
                        worksheet.Cells[1, 5].Value = "KDV Fiyatı(TL)";
                        worksheet.Cells[1, 5].Style.Font.Bold = true;
                        worksheet.Cells[1, 6].Value = "Toplam Fiyat(TL)";
                        worksheet.Cells[1, 6].Style.Font.Bold = true;
                        worksheet.Cells[1, 7].Value = "Sipariş Durumu";
                        worksheet.Cells[1, 7].Style.Font.Bold = true;
                        worksheet.Cells[1, 8].Value = "Tarih";
                        worksheet.Cells[1, 8].Style.Font.Bold = true;


                        int rowcount = 2; // ilk satır Colon sismleri 
                        if (customerreportResultModel.ReportData != null && customerreportResultModel.ReportLastResult != null)
                        {
                            foreach (var item in customerreportResultModel.ReportData)
                            {
                                worksheet.Cells[rowcount, 1].Value = item.CominicatePersonName;
                                worksheet.Cells[rowcount, 2].Value = item.ProductName;
                                worksheet.Cells[rowcount, 3].Value = item.UnitPrice;
                                worksheet.Cells[rowcount, 4].Value = item.Amount;
                                worksheet.Cells[rowcount, 5].Value = item.KdvPrice;
                                worksheet.Cells[rowcount, 6].Value = item.TotalPrice;
                                worksheet.Cells[rowcount, 7].Value = item.OrderStatus;
                                worksheet.Cells[rowcount, 8].Value = item.Date;

                                rowcount++;
                            }
                            int space = 5;
                            //Header
                            worksheet.Cells[rowcount + space, 1].Value = "Sipariş Sayısı";
                            worksheet.Cells[rowcount + space, 1].Style.Font.Bold = true;
                            worksheet.Cells[rowcount + space, 2].Value = "Toplam Sipariş Tutarı(TL)";
                            worksheet.Cells[rowcount + space, 2].Style.Font.Bold = true;
                            worksheet.Cells[rowcount + space, 3].Value = "Farklı Ürün Sipariş Sayısı";
                            worksheet.Cells[rowcount + space, 3].Style.Font.Bold = true;
                            worksheet.Cells[rowcount + space, 4].Value = "Toplam Aldığı Ürün Sayısı";
                            worksheet.Cells[rowcount + space, 4].Style.Font.Bold = true;
                            //Data
                            worksheet.Cells[(rowcount + space) + 1, 1].Value = customerreportResultModel.ReportLastResult.OrderCount;
                            worksheet.Cells[(rowcount + space) + 1, 2].Value = customerreportResultModel.ReportLastResult.TotalOrderPrice;
                            worksheet.Cells[(rowcount + space) + 1, 3].Value = customerreportResultModel.ReportLastResult.DifferentProductCount;
                            worksheet.Cells[(rowcount + space) + 1, 4].Value = customerreportResultModel.ReportLastResult.TotalProductCount;

                        }
                        #endregion
                        break;
                    case ReportType.ProductBased:
                        package.Workbook.Worksheets.Add("ÜrünRapor");

                        break;
                    case ReportType.General:
                        package.Workbook.Worksheets.Add("GenelRapor");
                        break;
                    default:
                        break;
                }
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel Dosyası |*.xlsx";
                saveFileDialog.ShowDialog();
                try
                {
                    Stream stream = saveFileDialog.OpenFile(); // oluşturduğumuz dosyayı açmak için yazdık.
                    package.SaveAs(stream);
                    stream.Close();
                    return true;
                }
                catch (Exception e)
                {
                    return false;
                }
            }


        }

    }
}

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
        // Method override etmek yerine property değerlerini null geçip istenen rapor türüne göre kullanıyorum property değerlerini set ediyorum.
        public bool CreateExcelFile(ReportType reportType, ReportResultModel<ReportDataForCustomer, ReportLastResultForCustomer> customerreportResultModel = null, ReportResultModel<ReportDataForProduct, ReportLastResultForProduct> productreportResultModel = null)
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
                            foreach (var item in customerreportResultModel.ReportData.CustomerViewReportModel)
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
                        #region ProductReportExcelTransaction

                        package.Workbook.Worksheets.Add("ÜrünRapor");
                        ExcelWorksheet worksheet2 = package.Workbook.Worksheets.FirstOrDefault();

                        worksheet2.Cells[1, 3].Value = "Ürün Alım Verisi";
                        worksheet2.Cells[1, 3].Style.Font.Bold = true;
                        worksheet2.Cells[1, 3].Style.Font.Size = 12;

                        int topspace = 2,rowsumcount =0;

                        worksheet2.Cells[topspace, 1].Value = "Ürün Adı";
                        worksheet2.Cells[topspace, 1].Style.Font.Bold = true;
                        worksheet2.Cells[topspace, 2].Value = "Alınan Birim Fiyat";
                        worksheet2.Cells[topspace, 2].Style.Font.Bold = true;
                        worksheet2.Cells[topspace, 3].Value = "Para Birimi";
                        worksheet2.Cells[topspace, 3].Style.Font.Bold = true;
                        worksheet2.Cells[topspace, 4].Value = "Miktar";
                        worksheet2.Cells[topspace, 4].Style.Font.Bold = true;
                        worksheet2.Cells[topspace, 5].Value = "Toplam Fiyat(TL)";
                        worksheet2.Cells[topspace, 5].Style.Font.Bold = true;
                        worksheet2.Cells[topspace, 6].Value = "Tarih";
                        worksheet2.Cells[topspace, 6].Style.Font.Bold = true;

                        //TedarikçiÜrünSİparişleri
                        int count = 1;
                        if (productreportResultModel.ReportData != null && productreportResultModel.ReportLastResult != null)
                        {
                            
                            
                            foreach (var item in productreportResultModel.ReportData.TakenProductList)
                            {
                                worksheet2.Cells[topspace + count, 1].Value = item.Product.Name;
                                worksheet2.Cells[topspace + count, 2].Value = item.UnitPrice;
                                if (item.MoneyTypeId == (int)MoneyType.TL)
                                {
                                    worksheet2.Cells[topspace + count, 3].Value = "TL";
                                }
                                else if (item.MoneyTypeId == (int)MoneyType.Dolar)
                                {
                                    worksheet2.Cells[topspace + count, 3].Value = $"$({item.MoneyTypeValue})";
                                }
                                else
                                    worksheet2.Cells[topspace + count, 3].Value = $"€({item.MoneyTypeValue})";

                                worksheet2.Cells[topspace + count, 4].Value = item.Amount;
                                worksheet2.Cells[topspace + count, 5].Value = item.TotalPrice;
                                worksheet2.Cells[topspace + count, 6].Value = item.DateString;

                                count++;
                            }
                             rowsumcount = count + topspace;
                        }
                        else
                        {
                            worksheet2.Cells[topspace, 3].Value = "Ürün alım verisi bulunmamaktadır.";
                            worksheet2.Cells[topspace, 5].Style.Font.Bold = true;
                        }

                        int middlespace = 5;
                        //Orta başlık
                        worksheet2.Cells[middlespace + rowsumcount-2, 3].Value = "Depodaki Stok Verisi";
                        worksheet2.Cells[middlespace + rowsumcount-2, 3].Style.Font.Bold = true;
                        worksheet2.Cells[middlespace + rowsumcount-2, 3].Style.Font.Size = 12;
                        //Depo Veris 
                        if (productreportResultModel.ReportData.WarehouseProduct != null)
                        {
                            worksheet2.Cells[middlespace + rowsumcount, 1].Value = "Ürün Adı";
                            worksheet2.Cells[middlespace + rowsumcount, 1].Style.Font.Bold = true;
                            worksheet2.Cells[middlespace + rowsumcount, 2].Value = "Güncel Stoktaki Miktarı";
                            worksheet2.Cells[middlespace + rowsumcount, 2].Style.Font.Bold = true;

                            worksheet2.Cells[middlespace + rowsumcount +1, 1].Value = productreportResultModel.ReportData.WarehouseProduct.Product.Name;
                            worksheet2.Cells[middlespace + rowsumcount +1, 2].Value =
                                productreportResultModel.ReportData.WarehouseProduct.Amount;
                        }
                        else
                        {
                            worksheet2.Cells[middlespace + rowsumcount - 1, 3].Value = "Stok Verisine ulaşılamadı.";
                            worksheet2.Cells[middlespace + rowsumcount - 1, 3].Style.Font.Bold = true;
                        }
                        rowsumcount = middlespace+ rowsumcount + 2; // aradaki boşluk satırını ayarlıyorum.
                                                                    // Ürün satış verisi -- 

                        worksheet2.Cells[rowsumcount +2, 4].Value = "Satış Verisi";
                        worksheet2.Cells[rowsumcount +2, 4].Style.Font.Bold = true;
                        worksheet2.Cells[rowsumcount +2, 4].Style.Font.Size= 12;

                        rowsumcount += 3;

                        worksheet2.Cells[rowsumcount, 1].Value = "Müşteri Adı";
                        worksheet2.Cells[rowsumcount, 1].Style.Font.Bold = true;
                        worksheet2.Cells[rowsumcount, 2].Value = "Ürün Adı";
                        worksheet2.Cells[rowsumcount, 2].Style.Font.Bold = true;
                        worksheet2.Cells[rowsumcount, 3].Value = "Satılan Birim Fiyat(TL)";
                        worksheet2.Cells[rowsumcount, 3].Style.Font.Bold = true;
                        worksheet2.Cells[rowsumcount, 4].Value = "Miktar";
                        worksheet2.Cells[rowsumcount, 4].Style.Font.Bold = true;
                        worksheet2.Cells[rowsumcount, 5].Value = "Kdv Tutarı(%18)";
                        worksheet2.Cells[rowsumcount, 5].Style.Font.Bold = true;
                        worksheet2.Cells[rowsumcount, 6].Value = "Toplam Fiyat(TL)";
                        worksheet2.Cells[rowsumcount, 6].Style.Font.Bold = true;
                        worksheet2.Cells[rowsumcount, 7].Value = "Sipariş Durumu";
                        worksheet2.Cells[rowsumcount, 7].Style.Font.Bold = true;
                        worksheet2.Cells[rowsumcount, 8].Value = "Tarih";
                        worksheet2.Cells[rowsumcount, 8].Style.Font.Bold = true;


                        if (productreportResultModel.ReportData.SoldProductList != null && productreportResultModel.ReportLastResult != null)
                        {

                            count = 1;
                            foreach (var item in productreportResultModel.ReportData.SoldProductList)
                            {
                                worksheet2.Cells[rowsumcount + count, 1].Value = item.Customer.CominicatePersonName;
                                worksheet2.Cells[rowsumcount + count, 2].Value = item.Product.Name;
                                worksheet2.Cells[rowsumcount + count, 3].Value = item.UnitPrice;
                                worksheet2.Cells[rowsumcount + count, 4].Value = item.Amount;
                                worksheet2.Cells[rowsumcount + count, 5].Value = item.KdvPrice;
                                worksheet2.Cells[rowsumcount + count, 6].Value = item.TotalPrice;
                                worksheet2.Cells[rowsumcount + count, 7].Value = item.OrderStatusTypeId == (int)OrderStatusType.Complated ? "Tamanlandı" : "Ön Sipariş";
                                worksheet2.Cells[rowsumcount + count, 8].Value = item.DateString;

                                count++;
                            }
                            rowsumcount = count + rowsumcount;
                        }
                        else
                        {
                            count = 1;
                            worksheet2.Cells[rowsumcount + count, 1].Value = "Bu aralıkta bir satış verisi bulunmamaktadır.";
                        }
                        rowsumcount += middlespace;

                        worksheet2.Cells[rowsumcount + 1, 1].Value = "Tedarikçiden Alınan Ürün miktarı";
                        worksheet2.Cells[rowsumcount + 1, 1].Style.Font.Bold = true;
                        worksheet2.Cells[rowsumcount + 1, 2].Value = "Satılan Ürün Miktarı";
                        worksheet2.Cells[rowsumcount + 1, 2].Style.Font.Bold = true;
                        worksheet2.Cells[rowsumcount + 1, 3].Value = "Stoktaki Ürün Miktarı";
                        worksheet2.Cells[rowsumcount + 1, 3].Style.Font.Bold = true;
                        worksheet2.Cells[rowsumcount + 1, 4].Value = "Tedarikçiye ödenen Tutar(TL)";
                        worksheet2.Cells[rowsumcount + 1, 4].Style.Font.Bold = true;
                        worksheet2.Cells[rowsumcount + 1, 5].Value = "Toplam Satılan Tutar(TL)";
                        worksheet2.Cells[rowsumcount + 1, 5].Style.Font.Bold = true;

                        //veri yerleştirme

                        worksheet2.Cells[rowsumcount + 2, 1].Value = productreportResultModel.ReportLastResult.TakenAmount;
                        worksheet2.Cells[rowsumcount + 2, 2].Value = productreportResultModel.ReportLastResult.SellAmount;
                        worksheet2.Cells[rowsumcount + 2, 3].Value = productreportResultModel.ReportLastResult.WarehouseAmount;
                        worksheet2.Cells[rowsumcount + 2, 4].Value = productreportResultModel.ReportLastResult.TotalPaidPrice;
                        worksheet2.Cells[rowsumcount + 2, 5].Value = productreportResultModel.ReportLastResult.TotalSellPrice;
                        #endregion
                        break;

                    default:
                        break;
                }
                //Dosyayı kaydedeceğimiz yolu seçiyoruz.
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

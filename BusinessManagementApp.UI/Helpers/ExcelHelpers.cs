using BussinesManagementApp.Dtos.ReportDtos;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessManagementApp.UI.Helpers
{
    public static class ExcelHelpers
    {
        public static void CreateExcelFile(ReportResultModel<ReportDataForCustomer, ReportLastResultForCustomer> reportData)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (var package = new ExcelPackage())
            {
                //ExcelPackage package = new ExcelPackage();
                package.Workbook.Worksheets.Add("MüşteriRapor");

                ExcelWorksheet worksheet = package.Workbook.Worksheets.FirstOrDefault();

                worksheet.Cells[1, 1].Value = "Yaz Dostum";
                worksheet.Cells[1, 1].Style.Font.Bold= true;
                //TODO Rapor oluşturulacak .
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel Dosyası |*.xlsx";
                saveFileDialog.ShowDialog();

                Stream stream = saveFileDialog.OpenFile(); // oluşturduğumuz dosyayı açmak için yazdık.
                package.SaveAs(stream);
                stream.Close();
            }
           

        }
    }
}

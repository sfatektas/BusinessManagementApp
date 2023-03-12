using BussinesManagementApp.Dtos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesManagementApp.Dtos.ReportDtos
{
    public class ReportLastResultForProduct : IReportLastResult
    {
        //Tedarikçiden alınan ürün miktarı 
        public int TakenAmount { get; set; }
        // Satılan ürün Miktarı
        public int SellAmount { get; set; }
        // Stoktaki ürün Miktarı
        public int WarehouseAmount { get; set; }
        //Toplam Satın alım Ödenen Tutar
        public double TotalPaidPrice { get; set; }
        //Toplam Satılan ciro 
        public double TotalSellPrice { get; set; }
        //Ciro
        public double Ciro { get; set; }

    }
}

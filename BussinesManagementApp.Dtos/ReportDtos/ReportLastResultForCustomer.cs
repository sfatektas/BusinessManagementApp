using BussinesManagementApp.Dtos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesManagementApp.Dtos.ReportDtos
{
    public class ReportLastResultForCustomer : IReportLastResult
    {
        //Toplam Sipariş
        public int OrderCount { get; set; }
        //Toplam Satış Tutarı  
        public double TotalOrderPrice { get; set; }
        //Kaç farklı ürün almış
        public int DifferentProductCount { get; set; }
        //Toplam Aldığı ürün sayısı
        public int TotalProductCount { get; set; }

    }
}

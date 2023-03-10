using BussinesManagementApp.Dtos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesManagementApp.Dtos.ReportDtos
{
    public class ReportDataForCustomer : IReportData
    {
        public string CominicatePersonName { get; set; }
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public double KdvPrice { get; set; }
        public double TotalPrice { get; set; }

        public int OrderStatusTypeId { get; set; }
        public string OrderStatus { get; set; }
        public DateTime Date { get; set; }

    }
}

using BussinesManagementApp.Dtos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesManagementApp.Dtos.ReportDtos
{
    public class ReportDataForProduct : IReportData
    {
        public List<SupplierOrderListDto> TakenProductList { get; set; }

        public WarehouseProductListDto WarehouseProduct{ get; set; }

        public List<CustomerOrderListDto> SoldProductList { get; set; }
    }
}

using BussinesManagementApp.Dtos.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesManagementApp.Dtos
{
    public class SupplierOrderListDto : IListDto
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public ProductListDto Product { get; set; }
        public double UnitPrice { get; set; }
        public int Amount { get; set; }
        public double TotalPrice { get; set; }
        public int MoneyTypeId { get; set; }
        public MoneyTypeListDto MoneyType { get; set; }
        public DateTime Date { get; set; }
    }
}

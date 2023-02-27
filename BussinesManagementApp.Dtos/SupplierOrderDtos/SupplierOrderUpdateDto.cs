using BussinesManagementApp.Dtos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesManagementApp.Dtos
{
    public class SupplierOrderUpdateDto : IUpdateDto
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public double UnitPrice { get; set; }
        public int Amount { get; set; }
        public double TotalPrice { get; set; }
        public int MoneyTypeId { get; set; }
        public bool IsActive { get; set; }

    }
}

using BussinesManagementApp.Dtos.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesManagementApp.Dtos
{
    public class CustomerOrderCreateDto : ICreateDto
    {
        public int CustomerId { get; set; }
        public int ProductId { get; set; }
        public int Amount { get; set; }
        public double UnitPrice { get; set; }
        public double KdvPrice { get; set; }
        public double TotalPrice { get; set; }
        public int OrderStatusTypeId { get; set; }
        public bool IsActive { get; set; }

    }
}

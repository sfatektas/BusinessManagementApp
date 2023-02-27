using BussinesManagementApp.Dtos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesManagementApp.Dtos
{
    public class CustomerOrderListDto : IListDto
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public CustomerListDto Customer { get; set; }
        public int ProductId { get; set; }
        public ProductListDto Product { get; set; }
        public int Amount { get; set; }
        public double UnitPrice { get; set; }
        public double KdvPrice { get; set; }
        public double TotalPrice { get; set; }
        public int OrderStatusTypeId { get; set; }
        public OrderStatusTypeListDto OrderStatusType { get; set; }
        public DateTime Date { get; set; }
        public bool IsActive { get; set; }

    }
}

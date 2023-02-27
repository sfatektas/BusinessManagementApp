using BussinesManagementApp.Dtos.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesManagementApp.Dtos
{
    public class ProductListDto : IListDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Origin { get; set; }
        public int SupplierId { get; set; }
        public SupplierListDto Supplier { get; set; }
        public double UnitPrice { get; set; }
        public bool IsActive { get; set; }


        //navigation prop
        public WarehouseProductListDto WarehouseProduct { get; set; }
        public List<SupplierOrderListDto> SupplierOrders { get; set; }
        public List<CustomerOrderListDto> CustomerOrders { get; set; }

    }
}

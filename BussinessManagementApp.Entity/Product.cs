using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessManagementApp.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public string Origin { get; set; }

        //[ForeignKey("Supplier")]
        public int SupplierId { get; set; }
        public Supplier Supplier { get; set; }
        public double UnitPrice { get; set; }

        //navigation prop
        public WarehouseProduct WarehouseProduct { get; set; }
        public List<SupplierOrder> SupplierOrders { get; set; }
        public List<CustomerOrder> CustomerOrders { get; set; }
    }
}

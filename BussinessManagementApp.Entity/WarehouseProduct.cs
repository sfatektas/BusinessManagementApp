using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessManagementApp.Entities
{
    public class WarehouseProduct : BaseEntity
    {
        //[ForeignKey("Product")]
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int Amount { get; set; }

    }
}

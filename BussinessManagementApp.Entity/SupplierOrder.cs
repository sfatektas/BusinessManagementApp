using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessManagementApp.Entities
{
    public class SupplierOrder : BaseEntity
    {
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public double UnitPrice { get; set; }
        public int Amount { get; set; }
        public double TotalPrice { get; set; }

        [ForeignKey("MoneyType")]
        public int MoneyTypeId { get; set; }
        public double MoneyTypeValue { get; set; } // Ürünün alınan tarihdeki Dolar, Euro değeri 
        public MoneyType MoneyType { get; set; }
        public DateTime Date { get; set; }

    }
}

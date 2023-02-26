using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessManagementApp.Entities
{
    public class CustomerOrder : BaseEntity
    {
        [ForeignKey("Customer")] //fluent validation ile ilişkilendirme yaparken hata aldığım için ilişkiler bazında Data Anotation kullandım
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int Amount { get; set; }
        public double UnitPrice { get; set; }
        public double KdvPrice { get; set; }
        public double TotalPrice { get; set; }

        [ForeignKey("OrderStatusType")]
        public int OrderStatusTypeId { get; set; }
        public OrderStatusType OrderStatusType { get; set; }
        public DateTime Date { get; set; }
    }
}

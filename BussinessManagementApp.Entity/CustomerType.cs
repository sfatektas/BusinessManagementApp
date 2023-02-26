using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessManagementApp.Entities
{
    public class CustomerType : BaseEntity
    {
        public string Defination { get; set; }

        public List<Customer> Customers { get; set; }
    }
}

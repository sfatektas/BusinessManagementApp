using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessManagementApp.Entities
{
    public class Customer : BaseEntity
    {
        public string CominicatePersonName { get; set; }
        public string TelNo { get; set; }
        public string Email { get; set; }
        public int CustomerTypeId { get; set; }
        public CustomerType CustomerType { get; set; }

        public List<CustomerOrder> CustomerOrders { get; set; }

        public string CompanyName { get; set; }
        public string TaxNo { get; set; }
        public string TradeRegisterNumber { get; set; }


    }
}

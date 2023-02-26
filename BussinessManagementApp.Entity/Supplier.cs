using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessManagementApp.Entities
{
    public class Supplier : BaseEntity
    {
        public string Info { get; set; }
        public string CominicatePersonName { get; set; }
        public string TelNo { get; set; }
        public string Email { get; set; }
        public string LogisticsCompany { get; set; }

        public List<Product> Products { get; set; }
    }
}

using BussinesManagementApp.Dtos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesManagementApp.Dtos
{
    public abstract class CustomerCreateDto : ICreateDto
    {
        public string CominicatePersonName { get; set; }
        public string TelNo { get; set; }
        public string Email { get; set; }
        public int CustomerTypeId { get; set; }
        public bool IsActive { get; set; } 
    }
    public class SingleCustomerCreateDto : CustomerCreateDto
    {

    }
    public class CorporateCustomerCreateDto : CustomerCreateDto
    {
        public string CompanyName { get; set; }
        public string TaxNo { get; set; }
        public string TradeRegisterNumber { get; set; }
    }
}

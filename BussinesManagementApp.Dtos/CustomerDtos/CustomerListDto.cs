using BussinesManagementApp.Dtos;
using BussinesManagementApp.Dtos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesManagementApp.Dtos
{
    public class CustomerListDto : IListDto
    {
        public int Id { get; set; }
        public string CominicatePersonName { get; set; }
        public string TelNo { get; set; }
        public string Email { get; set; }
        public int CustomerTypeId { get; set; }
        public CustomerTypeListDto CustomerType { get; set; }
        public List<CustomerOrderListDto> CustomerOrders { get; set; }
        public string CompanyName { get; set; }
        public string TaxNo { get; set; }
        public string TradeRegisterNumber { get; set; }

        public bool IsActive { get; set; }

    }
}

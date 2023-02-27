using BussinesManagementApp.Dtos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesManagementApp.Dtos
{
    public class SupplierCreateDto : ICreateDto
    {
        public string Info { get; set; }
        public string CominicatePersonName { get; set; }
        public string TelNo { get; set; }
        public string Email { get; set; }
        public string LogisticsCompany { get; set; }

    }
}

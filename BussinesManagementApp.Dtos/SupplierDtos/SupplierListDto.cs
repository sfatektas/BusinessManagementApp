using BussinesManagementApp.Dtos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesManagementApp.Dtos
{
    public class SupplierListDto : IListDto
    {
        public int Id { get; set; }
        public string Info { get; set; }
        public string CominicatePersonName { get; set; }
        public string TelNo { get; set; }
        public string Email { get; set; }
        public string LogisticsCompany { get; set; }
        public List<ProductListDto> Products { get; set; }
    }
}

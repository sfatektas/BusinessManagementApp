using BussinesManagementApp.Dtos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesManagementApp.Dtos
{
    public class CustomerTypeListDto : IListDto
    {
        public int Id { get; set; }

        public string Defination { get; set; }

        public List<CustomerListDto> Customers { get; set; }
    }
}

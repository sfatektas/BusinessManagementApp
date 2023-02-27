using BussinesManagementApp.Dtos.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesManagementApp.Dtos
{
    public class ProductCreateDto : ICreateDto
    {
        public string Name { get; set; }
        public string Origin { get; set; }
        public int SupplierId { get; set; }
        public double UnitPrice { get; set; }


    }
}

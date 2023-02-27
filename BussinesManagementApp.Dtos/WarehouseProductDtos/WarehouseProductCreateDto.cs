using BussinesManagementApp.Dtos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesManagementApp.Dtos
{
    public class WarehouseProductCreateDto : ICreateDto
    {
        public int ProductId { get; set; }
        public int Amount { get; set; }
    }
}

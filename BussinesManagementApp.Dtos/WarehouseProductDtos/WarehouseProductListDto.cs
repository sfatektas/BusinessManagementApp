using BussinesManagementApp.Dtos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesManagementApp.Dtos
{
    public class WarehouseProductListDto : IListDto
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public ProductListDto Product { get; set; }
        public int Amount { get; set; }
        public bool IsActive { get; set; }

    }
}

using BussinesManagementApp.Dtos;
using BussinessManagementApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesManagementApp.Bussines.Interfaces
{
    public interface IWarehouseProductService : IService<WarehouseProductCreateDto,WarehouseProductUpdateDto,WarehouseProductListDto,WarehouseProduct> , IQueryable<WarehouseProductListDto>
        
    {
    }
}

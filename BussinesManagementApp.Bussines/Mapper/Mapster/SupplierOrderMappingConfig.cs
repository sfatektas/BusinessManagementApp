using BussinesManagementApp.Dtos;
using BussinessManagementApp.Entities;
using Mapster;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesManagementApp.Bussines.Mapper.Mapster
{
    public class SupplierOrderMappingConfig : IRegister
    {
        public void Register(TypeAdapterConfig config)
        {
            config.NewConfig<SupplierOrder, SupplierOrderListDto>();
        }
    }
}

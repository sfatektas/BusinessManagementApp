using AutoMapper;
using BussinesManagementApp.Dtos;
using BussinessManagementApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesManagementApp.Bussines.Mapper.AutoMapper
{
    public class SupplierOrderProfile : Profile
    {
        public SupplierOrderProfile()
        {
            CreateMap<SupplierOrder, SupplierCreateDto>();
            CreateMap<SupplierOrder, SupplierListDto>();
            CreateMap<SupplierOrder, SupplierUpdateDto>();
            CreateMap<SupplierListDto, SupplierUpdateDto>();
        }
    }
}

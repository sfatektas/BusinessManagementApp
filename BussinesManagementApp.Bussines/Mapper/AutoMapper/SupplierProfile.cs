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
    public class SupplierProfile : Profile
    {
        public SupplierProfile()
        {
            CreateMap<Supplier, SupplierListDto>().ReverseMap();
            CreateMap<Supplier, SupplierUpdateDto>().ReverseMap();
            CreateMap<SupplierListDto, SupplierUpdateDto>().ReverseMap();
            CreateMap<Supplier, SupplierCreateDto>().ReverseMap();
        }
    }

}

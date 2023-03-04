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
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<Product,ProductCreateDto>().ReverseMap();
            CreateMap<Product,ProductListDto>().ReverseMap();
            CreateMap<Product,ProductUpdateDto>().ReverseMap();
            CreateMap<ProductListDto, ProductUpdateDto>().ReverseMap();
        }
    }
}

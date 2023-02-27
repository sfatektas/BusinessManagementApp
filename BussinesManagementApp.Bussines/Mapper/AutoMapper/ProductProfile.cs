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
            CreateMap<Product,ProductCreateDto>();
            CreateMap<Product,ProductListDto>();
            CreateMap<Product,ProductUpdateDto>();
            CreateMap<ProductListDto, ProductUpdateDto>();
        }
    }
}

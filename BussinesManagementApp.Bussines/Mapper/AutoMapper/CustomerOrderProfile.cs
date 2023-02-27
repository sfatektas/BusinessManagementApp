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
    public class CustomerOrderProfile : Profile
    {
        public CustomerOrderProfile()
        {
            CreateMap<CustomerOrder, CustomerOrderCreateDto>().ReverseMap();
            CreateMap<CustomerOrder, CustomerOrderListDto>().ReverseMap();
            CreateMap<CustomerOrder, CustomerOrderUpdateDto>().ReverseMap();
            CreateMap<CustomerOrderListDto, CustomerOrderUpdateDto>().ReverseMap();
        }
    }
}

using AutoMapper;
using BussinesManagementApp.Dtos;
using BussinesManagementApp.Dtos.ReportDtos;
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
            CreateMap<CustomerOrder, CustomerOrderListDto>().ForMember(x=>x.DateString , opt=>opt.MapFrom(src=>src.Date.ToString()));
            CreateMap<CustomerOrder, CustomerOrderUpdateDto>().ReverseMap();
            CreateMap<CustomerOrderListDto, CustomerOrderUpdateDto>().ReverseMap();
            CreateMap<CustomerOrder, CustomerViewReportModel>().ForMember(d => d.ProductName, s => s.MapFrom(s => s.Product.Name));
        }
    }
}

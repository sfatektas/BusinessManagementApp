using AutoMapper;
using BussinesManagementApp.Dtos;
using BussinessManagementApp.Entities;

namespace BussinesManagementApp.Bussines.Mapper.AutoMapper
{
    public class CustomerProfile : Profile
    {
        public CustomerProfile()
        {
            CreateMap<Customer, CustomerListDto>().ReverseMap();
            CreateMap<Customer, CustomerUpdateDto>().ReverseMap();
            CreateMap<CustomerListDto , CustomerUpdateDto>().ReverseMap();
            CreateMap<Customer, CustomerCreateDto>().ReverseMap();
        }
    }
}

using AutoMapper;
using BussinesManagementApp.Dtos;
using BussinessManagementApp.Entities;

namespace BussinesManagementApp.Bussines.Mapper.AutoMapper
{
    public class CustomerProfile : Profile
    {
        public CustomerProfile()
        {
            //Kalıtım verdiğim sınıfı nasıl mapleyeceğimi çözemedim.

            //.Include<SingleCustomer,SingleCustomerCreateDto>();

            CreateMap<Customer, CustomerListDto>().ReverseMap();

            CreateMap<Customer, CustomerUpdateDto>().ReverseMap();
            CreateMap<Customer, CustomerCreateDto>().ReverseMap();
            CreateMap<Customer, SingleCustomerCreateDto>().ReverseMap();
            CreateMap<Customer, SingleCustomerListDto>().ReverseMap();
            CreateMap<Customer, SingleCustomerUpdateDto>().ReverseMap();
            CreateMap<Customer, CorporateCustomerCreateDto>().ReverseMap();
            CreateMap<Customer, CorporateCustomerListDto>().ReverseMap();
            CreateMap<Customer, CorporateCustomerUpdateDto>().ReverseMap();
        }
    }
}

using AutoMapper;
using BusinessManagementApp.Common.Enums;
using BussinesManagementApp.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesManagementApp.Bussines.Mapper.AutoMapper
{
    public class OtherEntitesProfile : Profile
    {
        public OtherEntitesProfile()
        {
            CreateMap<MoneyType , MoneyTypeListDto>().ReverseMap();
            CreateMap<CustomerType , CustomerTypeListDto >().ReverseMap();
            CreateMap<OrderStatusType, OrderStatusTypeListDto>().ReverseMap();
        }
    }
}

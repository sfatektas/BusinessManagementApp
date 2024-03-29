﻿using AutoMapper;
using BussinesManagementApp.Dtos;
using BussinessManagementApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesManagementApp.Bussines.Mapper.AutoMapper
{
    public class WarehouseProductProfile : Profile
    {
        public WarehouseProductProfile()
        {
            CreateMap<WarehouseProduct, WarehouseProductCreateDto>().ReverseMap();
            CreateMap<WarehouseProduct, WarehouseProductListDto>().ReverseMap();
            CreateMap<WarehouseProduct, WarehouseProductUpdateDto>().ReverseMap();
            CreateMap<WarehouseProductListDto, WarehouseProductUpdateDto>().ReverseMap();
        }
    }
}

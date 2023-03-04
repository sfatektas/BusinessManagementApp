using AutoMapper;
using BussinesManagementApp.Bussines.Interfaces;
using BussinesManagementApp.Dtos;
using BussinessManagementApp.DataAccess.Interfaces;
using BussinessManagementApp.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesManagementApp.Bussines.Services
{
    public class WarehouseProductService : Service<WarehouseProductCreateDto, WarehouseProductUpdateDto, WarehouseProductListDto, WarehouseProduct>, IWarehouseService
    {
        public WarehouseProductService(IUow uow, IMapper mapper, IValidator<WarehouseProductCreateDto> createValidator, IValidator<WarehouseProductUpdateDto> updateValidator) : base(uow, mapper, createValidator, updateValidator)
        {
        }
    }
}

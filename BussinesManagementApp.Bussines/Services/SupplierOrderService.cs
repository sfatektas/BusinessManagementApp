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
    public class SupplierOrderService : Service<SupplierOrderCreateDto, SupplierOrderUpdateDto, SupplierOrderListDto, SupplierOrder>, ISupplierOrderService
    {
        public SupplierOrderService(IUow uow, IMapper mapper, IValidator<SupplierOrderCreateDto> createValidator, IValidator<SupplierOrderUpdateDto> updateValidator) : base(uow, mapper, createValidator, updateValidator)
        {
        }
    }
}

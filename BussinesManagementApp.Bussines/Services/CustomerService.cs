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
    public class CustomerService : Service<CustomerCreateDto, CustomerUpdateDto, CustomerListDto, Customer>, ICustomerService
    {
        public CustomerService(IUow uow, IMapper mapper, IValidator<CustomerCreateDto> createValidator, IValidator<CustomerUpdateDto> updateValidator) : base(uow, mapper, createValidator, updateValidator)
        {

        }
    }
}

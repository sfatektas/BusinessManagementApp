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
    public class ProductService : Service<ProductCreateDto, ProductUpdateDto, ProductListDto, Product>, IProductService
    {
        public ProductService(IUow uow, IMapper mapper, IValidator<ProductCreateDto> createValidator, IValidator<ProductUpdateDto> updateValidator) : base(uow, mapper, createValidator, updateValidator)
        {
        }
    }
}

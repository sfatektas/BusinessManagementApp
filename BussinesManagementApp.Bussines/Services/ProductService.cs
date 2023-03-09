using AutoMapper;
using BusinessManagementApp.Common;
using BusinessManagementApp.Common.Enums;
using BusinessManagementApp.Common.Interfaces;
using BussinesManagementApp.Bussines.Interfaces;
using BussinesManagementApp.Dtos;
using BussinessManagementApp.DataAccess.Interfaces;
using BussinessManagementApp.Entities;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BussinesManagementApp.Bussines.Services
{
    public class ProductService : Service<ProductCreateDto, ProductUpdateDto, ProductListDto, Product>, IProductService 
    {
        readonly IUow _uow;
        readonly IMapper _mapper;
        public ProductService(IUow uow, IMapper mapper, IValidator<ProductCreateDto> createValidator, IValidator<ProductUpdateDto> updateValidator) : base(uow, mapper, createValidator, updateValidator)
        {
            _uow = uow;
            _mapper = mapper;
        }

        public async Task<IResponse<List<ProductListDto>>> GetIncludedAll(bool ıncludeall = false)
        {
            var data = await _uow.GetRepository<Product>().GetQueryable().Include(x => x.Supplier).ToListAsync();
            if(data!=null)
                return new Response<List<ProductListDto>>(ResponseType.Success,_mapper.Map<List<ProductListDto>>(data));
            return new Response<List<ProductListDto>>(ResponseType.NotFound, null);
        }

        public async Task<IResponse<List<ProductListDto>>> GetIncludedAll(Expression<Func<Product, bool>> filter, bool allPropertyInclude = false)
        {
            var data = await _uow.GetRepository<Product>().GetQueryable().Where(x=>x.IsActive == true).Include(x => x.Supplier).ToListAsync();
            if (data != null)
                return new Response<List<ProductListDto>>(ResponseType.Success, _mapper.Map<List<ProductListDto>>(data));
            return new Response<List<ProductListDto>>(ResponseType.NotFound, null);
        }

        public async Task<IResponse<ProductListDto>> GetIncludedById(int id, bool ıncludeall = false)
        {
            var data = await _uow.GetRepository<Product>().GetQueryable().Where(x=>x.Id == id).Include(x => x.Supplier).FirstOrDefaultAsync();
            if (data != null)
                return new Response<ProductListDto>(ResponseType.Success, _mapper.Map<ProductListDto>(data));
            return new Response<ProductListDto>(ResponseType.NotFound, null);
        }
    }
}

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

namespace BussinesManagementApp.Bussines.Services
{
    public class WarehouseProductService : Service<WarehouseProductCreateDto, WarehouseProductUpdateDto, WarehouseProductListDto, WarehouseProduct>, IWarehouseProductService
    {
        readonly IMapper _mapper;
        readonly IUow _uow;
        public WarehouseProductService(IUow uow, IMapper mapper, IValidator<WarehouseProductCreateDto> createValidator, IValidator<WarehouseProductUpdateDto> updateValidator) : base(uow, mapper, createValidator, updateValidator)
        {
            _uow = uow;
            _mapper = mapper;
        }

        public async Task<IResponse<List<WarehouseProductListDto>>> GetIncludedAll(bool allPropertyInclude=false)
        {
            var data = !allPropertyInclude ? await _uow.GetRepository<WarehouseProduct>().GetQueryable().Include(x => x.Product).ToListAsync():
                await _uow.GetRepository<WarehouseProduct>().GetQueryable().Include(x => x.Product).ThenInclude(x=>x.Supplier).ToListAsync()
            ;
            if (data != null)
                return new Response<List<WarehouseProductListDto>>(ResponseType.Success, _mapper.Map<List<WarehouseProductListDto>>(data));
            return new Response<List<WarehouseProductListDto>>(ResponseType.NotFound, "Bulunamadı", null);
            
        }

        public async Task<IResponse<WarehouseProductListDto>> GetIncludedById(int id , bool allPropertyInclude = false)
        {
            var data = !allPropertyInclude ? await _uow.GetRepository<WarehouseProduct>().GetQueryable().Where(x=>x.Id == id).Include(x => x.Product).FirstOrDefaultAsync() : await _uow.GetRepository<WarehouseProduct>().GetQueryable().Where(x => x.Id == id).Include(x => x.Product).ThenInclude(x=>x.Supplier).FirstOrDefaultAsync();
            if (data != null)
                return new Response<WarehouseProductListDto>(ResponseType.Success, _mapper.Map<WarehouseProductListDto>(data));
            return new Response<WarehouseProductListDto>(ResponseType.NotFound, "Bulunamadı", null);
        }
    }
}

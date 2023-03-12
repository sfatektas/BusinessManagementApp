using AutoMapper;
using BusinessManagementApp.Common;
using BusinessManagementApp.Common.Enums;
using BusinessManagementApp.Common.Interfaces;
using BussinesManagementApp.Bussines.Helpers.Extension;
using BussinesManagementApp.Bussines.Interfaces;
using BussinesManagementApp.Dtos;
using BussinessManagementApp.DataAccess.Interfaces;
using BussinessManagementApp.Entities;
using FluentValidation;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Update;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BussinesManagementApp.Bussines.Services
{
    public class CustomerOrderService : Service<CustomerOrderCreateDto, CustomerOrderUpdateDto, CustomerOrderListDto, CustomerOrder> , ICustomerOrderService
    {
        readonly IUow _uow;
        readonly IMapper _mapper;
        readonly IValidator<CustomerOrderCreateDto> _createValidator;

        public CustomerOrderService(IUow uow, IMapper mapper, IValidator<CustomerOrderCreateDto> createValidator, IValidator<CustomerOrderUpdateDto> updateValidator) : base(uow, mapper, createValidator, updateValidator)
        {
            _uow = uow;
            _mapper = mapper;
            _createValidator = createValidator;
        }

        public async Task<IResponse<CustomerOrderCreateDto>> AddCustomerOrderAndUpdateWarehouse(CustomerOrderCreateDto dto)
        {
            var result = await _createValidator.ValidateAsync(dto);
            if (result.IsValid)
            {
                var warehouseProduct = await _uow.GetRepository<WarehouseProduct>().GetByFilterAsync(x => x.ProductId == dto.ProductId);
                if (warehouseProduct != null)
                {
                    if (dto.OrderStatusTypeId != (int)BusinessManagementApp.Common.Enums.OrderStatusType.PreOrder)
                    {
                        if (dto.Amount > warehouseProduct.Amount)
                        {
                            return new Response<CustomerOrderCreateDto>(ResponseType.Error, "Bu ürüne ait ,depoda yeterli miktarda stok yok. Ön sipariş geçebilirsiniz. ", dto);
                        }
                        warehouseProduct.Amount -= dto.Amount; // Depodaki ürün sayısını sipariş kadar düşüyorum.
              
                        await _uow.GetRepository<CustomerOrder>().CreateAsync(_mapper.Map<CustomerOrder>(dto));
                        _uow.GetRepository<WarehouseProduct>().Update(warehouseProduct);
                        await _uow.SaveChangesAsync(); // unit of work ile veri bütünlüğünü sağladım.  
                        return new Response<CustomerOrderCreateDto>(ResponseType.Success, $"Satış başarılı bir şekilde oluşturuldu. Stokta kalan ürün miktarı :{warehouseProduct.Amount}", dto);
                       
                    }
                    else
                    {
                        await _uow.GetRepository<CustomerOrder>().CreateAsync(_mapper.Map<CustomerOrder>(dto));
                        await _uow.SaveChangesAsync();
                        return new Response<CustomerOrderCreateDto>(ResponseType.Success, $"Ön siparişiniz başarılı bir şekilde oluşturuldu.", dto);
                    }

                }
                return new Response<CustomerOrderCreateDto>(ResponseType.NotFound, "Bu ürüne ait depoda kayıt bulunmamaktadır.", dto);
            }
            return new Response<CustomerOrderCreateDto>(ResponseType.ValidationError, dto, result.GetValidationErrors());
        }

        public async Task<IResponse> ComplatePreOrderAndUpdateWarehouse(int CustomerOrderId)
        {
            var CustomerOrderData = await _uow.GetRepository<CustomerOrder>().GetByFilterAsync(x=>x.Id==CustomerOrderId && x.IsActive == true && x.OrderStatusTypeId == (int)BusinessManagementApp.Common.Enums.OrderStatusType.PreOrder);
            if (CustomerOrderData != null)
            {
                var WareHouseProductData = await _uow.GetRepository<WarehouseProduct>().GetByFilterAsync(x => x.ProductId == CustomerOrderData.ProductId && x.Amount !=0);
                if (WareHouseProductData != null)
                {
                    if (WareHouseProductData.Amount >= CustomerOrderData.Amount)
                    {
                        WareHouseProductData.Amount -= CustomerOrderData.Amount; // stoktaki ürünü güncelliyoruz.
                        CustomerOrderData.OrderStatusTypeId = (int)BusinessManagementApp.Common.Enums.OrderStatusType.Complated; // ön siparişi tamamlandı olarak işaretliyorum.
                        _uow.GetRepository<WarehouseProduct>().Update(WareHouseProductData);
                        _uow.GetRepository<CustomerOrder>().Update(CustomerOrderData);
                        await _uow.SaveChangesAsync();
                        return new Response (ResponseType.Success,$"Ön sipariş tamamlandı . Stoktaki ürün mikratı güncellendi. Stokta kalan ürün miktarı:{WareHouseProductData.Amount}");
                    }
                    else
                        return new Response(ResponseType.Error, $"Ön siparişi tamamlamak için ürüne ait depoda yeterli stok bulunmamaktadır. Güncel Stok :{WareHouseProductData.Amount}");
                }
                return new Response(ResponseType.Error, "Ürün stokta bulunmamaktadır.");
            }
            return new Response(ResponseType.NotFound , "Bu ürün ID'sine sahip aktif bir ön sipariş bulunmamaktadır. ");
        }

        public async Task<IResponse<List<CustomerOrderListDto>>> GetIncludeAllAndLastTenRow()
        {
            var data = await _uow.GetRepository<CustomerOrder>().GetQueryable().Include(x => x.Customer).Include(x => x.Product).OrderByDescending(x=>x.Id).Take(10).AsNoTracking().ToListAsync();
            if(data != null)
                return new Response<List<CustomerOrderListDto>>(ResponseType.Success, _mapper.Map<List<CustomerOrderListDto>>(data));
            return new Response<List<CustomerOrderListDto>>(ResponseType.NotFound, "Kayıt Bulunamadı.", null);

        }

        public async Task<IResponse<List<CustomerOrderListDto>>> GetIncludedAll(bool allPropertyInclude = false)
        {
            var data = !allPropertyInclude ? await _uow.GetRepository<CustomerOrder>().GetQueryable().Include(x => x.Customer).Include(x=>x.Product).AsNoTracking().ToListAsync() :
    await _uow.GetRepository<CustomerOrder>().GetQueryable().Include(x => x.Customer).Include(x => x.Product).AsNoTracking().ToListAsync()
;
            if (data != null)
                return new Response<List<CustomerOrderListDto>>(ResponseType.Success, _mapper.Map<List<CustomerOrderListDto>>(data));
            return new Response<List<CustomerOrderListDto>>(ResponseType.NotFound, "Bulunamadı.", null);
        }

        public async Task<IResponse<List<CustomerOrderListDto>>> GetIncludedAll(Expression<Func<CustomerOrder, bool>> filter, bool allPropertyInclude = false)
        {
            var data = !allPropertyInclude ? await _uow.GetRepository<CustomerOrder>().GetQueryable().Where(filter).Include(x => x.Product).AsNoTracking().ToListAsync() :
   await _uow.GetRepository<CustomerOrder>().GetQueryable().Where(filter).Include(x => x.Product).Include(x=>x.Customer).AsNoTracking().ToListAsync()
;// burda orderstatus modelini methoda include ettiğimde hata alıyorum****
            if (data != null)
            {
                var mappeddata = _mapper.Map<List<CustomerOrderListDto>>(data);
                return new Response<List<CustomerOrderListDto>>(ResponseType.Success, _mapper.Map<List<CustomerOrderListDto>>(data));
            }
            return new Response<List<CustomerOrderListDto>>(ResponseType.NotFound, "Bulunamadı.", null);
        }

        public async Task<IResponse<CustomerOrderListDto>> GetIncludedById(int id, bool allPropertyInclude = false)
        {
            var data = !allPropertyInclude ? await _uow.GetRepository<CustomerOrder>().GetQueryable().Where(x => x.Id == id && x.IsActive == true).Include(x => x.Product).AsNoTracking().FirstOrDefaultAsync() : await _uow.GetRepository<CustomerOrder>().GetQueryable().Where(x => x.Id == id && x.IsActive == true).Include(x => x.Product).Include(x => x.Customer).AsNoTracking().FirstOrDefaultAsync();
            if (data != null)
                return new Response<CustomerOrderListDto>(ResponseType.Success, _mapper.Map<CustomerOrderListDto>(data));
            return new Response<CustomerOrderListDto>(ResponseType.NotFound, "Bulunamadı.", null);
        }
    }
}

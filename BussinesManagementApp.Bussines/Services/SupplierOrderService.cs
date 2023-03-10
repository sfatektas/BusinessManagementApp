using AutoMapper;
using BusinessManagementApp.Common;
using BusinessManagementApp.Common.Enums;
using BusinessManagementApp.Common.Interfaces;
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
        readonly IMapper _mapper;
        readonly IUow _uow;
        IValidator<SupplierOrderCreateDto> _createValidator;

        public SupplierOrderService(IUow uow, IMapper mapper, IValidator<SupplierOrderCreateDto> createValidator, IValidator<SupplierOrderUpdateDto> updateValidator) : base(uow, mapper, createValidator, updateValidator)
        {
            _mapper = mapper;
            _uow = uow;
            _createValidator = createValidator;
        }

        public async Task<IResponse<SupplierOrderCreateDto>> AddSupplierOrderAndWarehouseProductUpdate(SupplierOrderCreateDto dto)
        {
            var result = _createValidator.Validate(dto);
            if (result.IsValid)
            {
                await _uow.GetRepository<SupplierOrder>().CreateAsync(_mapper.Map<SupplierOrder>(dto));
                var WarehouseProductData = await _uow.GetRepository<WarehouseProduct>().GetByFilterAsync(x=>x.ProductId == dto.ProductId && x.IsActive == true);
                if (WarehouseProductData != null)
                {
                    WarehouseProductData.Amount += dto.Amount; // stokta hali hazırda olan miktara sipariş edilen miktaerı ekliyourm.
                    _uow.GetRepository<WarehouseProduct>().Update(WarehouseProductData);
                    await _uow.SaveChangesAsync();
                    return new Response<SupplierOrderCreateDto>(ResponseType.Success, $"Ürün stoğa başarılı bir şekilde eklendi . Güncel ürün stoğu : {WarehouseProductData.Amount}", dto);
                }
                else
                {
                    var productData = await _uow.GetRepository<Product>().GetByFilterAsync(x=>x.Id == dto.ProductId && x.IsActive == true); 
                    productData.UnitPrice = productData.UnitPrice == 0 ? dto.UnitPrice * 1.25 : productData.UnitPrice;   // burda yapılan işlem ürün ilk defa tedarik ediliyor ise satış fiyatı default olarak %25 karlı fiyat olarak hesaplanacaktır. Eğer daha önceden bir fiyatı bellirlenmiş ise o fiyat kalacaktır.
                     _uow.GetRepository<Product>().Update(productData);
                    await _uow.GetRepository<WarehouseProduct>().CreateAsync(new()
                    {
                        ProductId = dto.ProductId,
                        Amount = dto.Amount,
                    });
                    await _uow.SaveChangesAsync();
                    return new Response<SupplierOrderCreateDto>(ResponseType.Success, $"Ürün stoğa başarılı bir şekilde eklendi . Güncel ürün stoğu : {dto.Amount}", dto);
                }

            }
            return new Response<SupplierOrderCreateDto>(ResponseType.ValidationError,dto);
        }
    }
}

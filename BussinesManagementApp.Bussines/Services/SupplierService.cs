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
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesManagementApp.Bussines.Services
{
    public class SupplierService : Service<SupplierCreateDto, SupplierUpdateDto, SupplierListDto, Supplier>, ISupplierService
    {
        readonly IUow _uow;
        readonly IValidator<SupplierUpdateDto> _updateValidator;
        readonly IMapper _mapper;
        public SupplierService(IUow uow, IMapper mapper, IValidator<SupplierCreateDto> createValidator, IValidator<SupplierUpdateDto> updateValidator) : base(uow, mapper, createValidator, updateValidator)
        {
            _uow = uow;
            _updateValidator = updateValidator;
            _mapper = mapper;
        }
        public async override Task<IResponse<SupplierCreateDto>> CreateAsync(SupplierCreateDto dto)
        {
            var data = await _uow.GetRepository<Supplier>().GetByFilterAsync(x => x.TelNo == dto.TelNo);
            if (data is not null)
                return new Response<SupplierCreateDto>(ResponseType.Error, "Bu telefon numarasına ait bir kayıt mevcut. ", dto);
            return await base.CreateAsync(dto);
        }
        public async override Task<IResponse<SupplierUpdateDto>> UpdateAsync(SupplierUpdateDto dto)
        {
            var data = await _uow.GetRepository<Supplier>().GetByFilterAsync(x => (x.TelNo == dto.TelNo || x.Email == dto.Email) && x.Id != dto.Id);
            if (data is not null)
                return new Response<SupplierUpdateDto>(ResponseType.Error, "Telefon numarası veya Email daha önceden alınmış güncellenemez.", dto);
            return await base.UpdateAsync(dto);
        }
    }
}

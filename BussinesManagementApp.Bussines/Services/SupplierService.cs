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
    public class SupplierService : Service<SupplierCreateDto, SupplierUpdateDto, SupplierListDto, Supplier>, ISupplierService
    {
        readonly IUow _uow;
        public SupplierService(IUow uow, IMapper mapper, IValidator<SupplierCreateDto> createValidator,IValidator<SupplierUpdateDto> updateValidator) : base(uow, mapper, createValidator,updateValidator)
        {
            _uow = uow;
        }
        public async override Task<IResponse<SupplierCreateDto>> CreateAsync(SupplierCreateDto dto)
        {
            var data = await _uow.GetRepository<Supplier>().GetByFilterAsync(x=>x.TelNo == dto.TelNo);
            if(data is not null)
                return new Response<SupplierCreateDto>(ResponseType.Error,"Bu telefon numarasına ait bir kayıt mevcut. ",dto);
            return await base.CreateAsync(dto);
        }
    }
}

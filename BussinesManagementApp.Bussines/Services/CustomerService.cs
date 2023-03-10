using AutoMapper;
using BusinessManagementApp.Common;
using BusinessManagementApp.Common.Enums;
using BusinessManagementApp.Common.Interfaces;
using BussinesManagementApp.Bussines.Interfaces;
using BussinesManagementApp.Dtos;
using BussinessManagementApp.DataAccess.Interfaces;
using BussinessManagementApp.Entities;
using FluentValidation;


namespace BussinesManagementApp.Bussines.Services
{
    public class CustomerService : Service<CustomerCreateDto, CustomerUpdateDto, CustomerListDto, Customer>, ICustomerService
    {
        private readonly IUow _uow;
        public CustomerService(IUow uow, IMapper mapper, IValidator<CustomerCreateDto> createValidator, IValidator<CustomerUpdateDto> updateValidator) : base(uow, mapper, createValidator, updateValidator)
        {
            _uow= uow;
        }
        public async override Task<IResponse<CustomerCreateDto>> CreateAsync(CustomerCreateDto dto)
        {
            var data = await _uow.GetRepository<Customer>().GetByFilterAsync(x=>x.TelNo == dto.TelNo);
            if(data != null)
                return new Response<CustomerCreateDto>(ResponseType.Error, "Aynı telefon numarasına sahip bir müşteri mevcut", dto);
            return await base.CreateAsync(dto);
        }
    }
}

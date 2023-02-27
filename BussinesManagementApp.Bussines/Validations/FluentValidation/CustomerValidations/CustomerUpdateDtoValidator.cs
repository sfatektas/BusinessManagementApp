using BussinesManagementApp.Dtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesManagementApp.Bussines.Validations.FluentValidation.CustomerValidations
{
    public class SingleCustomerUpdateDtoValidator : AbstractValidator<SingleCustomerUpdateDto>
    {
        public SingleCustomerUpdateDtoValidator()
        {
            RuleFor(x => x.Email).NotEmpty().EmailAddress();
            RuleFor(x => x.TelNo).NotEmpty();
            RuleFor(x => x.CominicatePersonName).NotEmpty();
            RuleFor(x => x.CustomerTypeId).NotEqual(0);
        }
    }
    public class CorporateCustomerUpdateDtoValidator : AbstractValidator<CorporateCustomerUpdateDto>
    {
        public CorporateCustomerUpdateDtoValidator()
        {
            RuleFor(x => x.Email).NotEmpty().EmailAddress();
            RuleFor(x => x.TelNo).NotEmpty();
            RuleFor(x => x.CominicatePersonName).NotEmpty();
            RuleFor(x => x.CustomerTypeId).NotEqual(0);
            RuleFor(x => x.TradeRegisterNumber).NotEmpty();
            RuleFor(x => x.TaxNo).NotEmpty();
            RuleFor(x => x.CompanyName).NotEmpty();
        }
    }
}

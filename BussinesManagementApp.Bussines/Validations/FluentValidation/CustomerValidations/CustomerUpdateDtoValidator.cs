using BusinessManagementApp.Common.Enums;
using BussinesManagementApp.Dtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesManagementApp.Bussines.Validations.FluentValidation.CustomerValidations
{
    public class CustomerUpdateDtoValidator : AbstractValidator<CustomerUpdateDto>
    {
        public CustomerUpdateDtoValidator()
        {
            RuleFor(x => x.Email).NotEmpty().EmailAddress();
            RuleFor(x => x.TelNo).NotEmpty();
            RuleFor(x => x.CominicatePersonName).NotEmpty();
            RuleFor(x => x.CustomerTypeId).NotEqual(0);
            RuleFor(x => x.TradeRegisterNumber).NotEmpty().When(x=>x.CustomerTypeId!=(int)CustomerType.Single);
            RuleFor(x => x.TaxNo).NotEmpty().When(x => x.CustomerTypeId != (int)CustomerType.Single);
            RuleFor(x => x.CompanyName).NotEmpty().When(x => x.CustomerTypeId != (int)CustomerType.Single);
        }
    }
}

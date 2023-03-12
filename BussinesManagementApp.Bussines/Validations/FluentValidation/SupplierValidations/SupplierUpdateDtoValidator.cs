using BussinesManagementApp.Dtos;
using FluentValidation;
using Microsoft.EntityFrameworkCore.Update;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesManagementApp.Bussines.Validations.FluentValidation.SupplierValidations
{
    public class SupplierUpdateDtoValidator : AbstractValidator<SupplierUpdateDto>
    {
        public SupplierUpdateDtoValidator()
        {
            RuleFor(x => x.Email).NotEmpty().EmailAddress();
            RuleFor(x => x.Info).NotEmpty();
            RuleFor(x => x.TelNo).NotEmpty().Matches("^[0-9]*$").WithMessage("Telefon numarası sadece sayı formatında olmalı."); ;
            RuleFor(x => x.LogisticsCompany).NotEmpty();
            RuleFor(x => x.CominicatePersonName).NotEmpty();
        }
    }
}

using BussinesManagementApp.Dtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesManagementApp.Bussines.Validations.FluentValidation.SupplierOrderValidations
{
    public class SupplierOrderCreateValidator : AbstractValidator<SupplierOrderCreateDto>
    {
        public SupplierOrderCreateValidator()
        {
            RuleFor(x=>x.ProductId).GreaterThan(0);
            RuleFor(x=>x.UnitPrice).GreaterThan(0);
            RuleFor(x=>x.Amount).GreaterThan(0);
            RuleFor(x=>x.MoneyTypeId).NotEqual(0);
            RuleFor(x=>x.TotalPrice).GreaterThan(0).Equal(x=>x.UnitPrice * x.Amount);
        }
    }
}

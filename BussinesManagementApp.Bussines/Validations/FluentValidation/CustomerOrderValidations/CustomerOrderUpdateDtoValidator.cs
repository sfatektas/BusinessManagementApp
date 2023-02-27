using BussinesManagementApp.Dtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesManagementApp.Bussines.Validations.FluentValidation.CustomerOrderValidations
{
    public class CustomerOrderUpdateDtoValidator : AbstractValidator<CustomerOrderUpdateDto>
    {
        public CustomerOrderUpdateDtoValidator()
        {
            RuleFor(x => x.CustomerId).NotEqual(0);
            RuleFor(x => x.ProductId).NotEqual(0);
            RuleFor(x => x.UnitPrice).GreaterThan(0).WithMessage("Ürünün birim fiyatı sıfıra eşit olamaz.").Must(x => x.GetType() == typeof(double));
            RuleFor(x => x.TotalPrice).Equal(x => x.UnitPrice * x.Amount + x.KdvPrice);
            RuleFor(x => x.Amount).NotEqual(0).Must(x => x.GetType() == typeof(double));
            RuleFor(x => x.KdvPrice).NotEqual(0).Must(x => x.GetType() == typeof(double));
        }
    }
}

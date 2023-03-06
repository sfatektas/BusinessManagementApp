using BussinesManagementApp.Dtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesManagementApp.Bussines.Validations.FluentValidation.ProductValidations
{
    public class ProductCreateDtoValidator : AbstractValidator<ProductCreateDto>
    {
        public ProductCreateDtoValidator()
        {
            RuleFor(x => x.Name).NotEmpty();
            RuleFor(x=>x.SupplierId).NotEqual(0);
            RuleFor(x=>x.Origin).NotEmpty();
            RuleFor(x=>x.UnitPrice).GreaterThanOrEqualTo(0);
        }
    }
}

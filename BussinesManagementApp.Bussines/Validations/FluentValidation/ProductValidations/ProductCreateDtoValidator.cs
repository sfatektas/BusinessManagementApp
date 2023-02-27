using BussinesManagementApp.Dtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesManagementApp.Bussines.Validations.FluentValidation.ProductValidations
{
    public class ProductCreateValidator : AbstractValidator<ProductCreateDto>
    {
        public ProductCreateValidator()
        {
            RuleFor(x => x.Name).NotEmpty();
            RuleFor(x=>x.SupplierId).NotEmpty();
            RuleFor(x=>x.Origin).NotEmpty();
            RuleFor(x=>x.UnitPrice).NotEmpty();
        }
    }
}

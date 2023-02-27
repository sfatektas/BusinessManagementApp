using BussinesManagementApp.Dtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesManagementApp.Bussines.Validations.FluentValidation.WarehouseProductValidations
{
    public class WarehouseProductUpdateDtoValidator : AbstractValidator<WarehouseProductUpdateDto>
    {
        public WarehouseProductUpdateDtoValidator()
        {
            RuleFor(x => x.ProductId).NotEqual(0);
            RuleFor(x => x.Amount).GreaterThan(0);
        }
    }
}

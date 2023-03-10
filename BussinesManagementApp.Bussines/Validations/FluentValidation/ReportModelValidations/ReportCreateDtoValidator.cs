using BusinessManagementApp.Common.Enums;
using BussinesManagementApp.Dtos.ReportDtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesManagementApp.Bussines.Validations.FluentValidation.ReportModelValidations
{
    public class ReportQueryDtoValidator : AbstractValidator<ReportQueryDto>
    {
        public ReportQueryDtoValidator()
        {
            RuleFor(x=>x.ReportTypeId).NotEqual(0).WithMessage("Rapor Türü seçilmesi zorunludur.");
            RuleFor(x=>x.TimeRangeTypeId).NotEqual(0).WithMessage("Zaman Aralığı türü seçilmesi zorunludur.");
            RuleFor(x=>x.CustomerId).NotEqual(0).When(x=>x.ReportTypeId == (int)ReportType.CustomerBased).WithMessage("Müşteri seçimi yapılmalıdır.");
            RuleFor(x=>x.ProductId).NotEqual(0).When(x=>x.ReportTypeId == (int)ReportType.ProductBased).WithMessage("Ürün seçimi yapılmalıdır.");
        }
    }
}

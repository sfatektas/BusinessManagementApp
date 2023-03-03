using BusinessManagementApp.Common;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesManagementApp.Bussines.Helpers.Extension
{
    public static class ValidationExtension
    {
        public static List<ValidationError> GetValidationErrors (this ValidationResult result)
        {
            var errors = new List<ValidationError> ();
            foreach (var error in result.Errors)
            {
                errors.Add( new ValidationError { ErrorCode =error.ErrorCode,ErrorMessage= error.ErrorMessage}); 
            }
            return errors;
        }
    }
}

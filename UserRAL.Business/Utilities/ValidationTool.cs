using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using UserRAL.Business.Abstract;

namespace UserRAL.Business.Utilities
{
    public class ValidationTool:IValidationTool
    {
        public void Validate<T>(IValidator<T> validator, T entity)
        {
            var result = validator.Validate(entity);
            if (result.Errors.Count > 0)
            {
                throw new ValidationException(result.Errors);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace UserRAL.Business.Abstract
{
    public interface IValidationTool
    {
        void Validate<T>(IValidator<T> validator, T entity);
    }
}

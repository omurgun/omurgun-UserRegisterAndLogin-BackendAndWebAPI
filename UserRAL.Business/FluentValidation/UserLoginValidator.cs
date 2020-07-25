using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using UserRAL.Entities.Concrete;

namespace UserRAL.Business.FluentValidation
{
    public class UserLoginValidator : AbstractValidator<User>
    {
        public UserLoginValidator()
        {
            RuleFor(x => x.UserName).NotEmpty();
            RuleFor(x => x.UserName).MinimumLength(5);

            RuleFor(x => x.Password).NotEmpty();
            RuleFor(x => x.Password).MinimumLength(8);
        }
    }
}

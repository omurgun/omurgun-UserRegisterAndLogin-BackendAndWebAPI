using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using UserRAL.Entities.Concrete;

namespace UserRAL.Business.FluentValidation
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(x => x.Name).NotEmpty();
            RuleFor(x => x.Name).MinimumLength(2);

            RuleFor(x => x.Surname).NotEmpty();
            RuleFor(x => x.Surname).MinimumLength(2);

            RuleFor(x => x.UserName).NotEmpty();
            RuleFor(x => x.UserName).MinimumLength(5);

            RuleFor(x => x.Email).NotEmpty();
            RuleFor(x => x.Email).EmailAddress();

            RuleFor(x => x.Password).NotEmpty();
            RuleFor(x => x.Password).MinimumLength(8);


        }
    }
}

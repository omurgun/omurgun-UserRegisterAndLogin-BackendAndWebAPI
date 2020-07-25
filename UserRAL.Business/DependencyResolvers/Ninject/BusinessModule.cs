using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject.Modules;
using UserRAL.Business.Abstract;
using UserRAL.Business.Concrete;
using UserRAL.Business.Utilities;
using UserRAL.DataAccess.Abstract;
using UserRAL.DataAccess.Concrete.EntityFramework;

namespace UserRAL.Business.DependencyResolvers.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IUserService>().To<UserManager>();
            Bind<IUserDal>().To<EfUserDal>();

            Bind<IRoleService>().To<RoleManager>();
            Bind<IRoleDal>().To<EfRoleDal>();

            Bind<IEncryptText>().To<PasswordEncrypt>();

            Bind<IValidationTool>().To<ValidationTool>();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserRAL.DataAccess.Abstract;
using UserRAL.Entities.Concrete;

namespace UserRAL.DataAccess.Concrete.EntityFramework
{
    public class EfRoleDal : EfEntityRepositoryBase<Role, UserDbContext>, IRoleDal
    {

    }
}

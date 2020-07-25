using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserRAL.Entities.Concrete;

namespace UserRAL.Business.Abstract
{
    public interface IRoleService
    {
        List<Role> GetAllRoles();

    }
}

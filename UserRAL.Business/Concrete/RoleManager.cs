using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserRAL.Business.Abstract;
using UserRAL.DataAccess.Abstract;
using UserRAL.Entities.Concrete;

namespace UserRAL.Business.Concrete
{
    public class RoleManager : IRoleService
    {
        private IRoleDal _roleDal;

        public RoleManager(IRoleDal roleDal)
        {
            _roleDal = roleDal;
        }

        public List<Role> GetAllRoles()
        {
            return _roleDal.GetAll();
        }
    }
}

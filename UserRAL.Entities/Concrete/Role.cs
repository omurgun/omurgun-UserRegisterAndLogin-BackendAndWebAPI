using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserRAL.Entities.Abstract;

namespace UserRAL.Entities.Concrete
{
    public class Role : IEntity
    {
        public int RoleId { get; set; }
        public string RoleName { get; set; }
    }
}

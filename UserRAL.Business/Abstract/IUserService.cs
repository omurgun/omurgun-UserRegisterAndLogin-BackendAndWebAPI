using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserRAL.Entities.Concrete;

namespace UserRAL.Business.Abstract
{
    public interface IUserService
    {
        List<User> GetAllUsers();
        List<User> GetUsersByRole(int roleId);
        List<User> GetUsersByUserName(string userName);
        void AddUser(User user);
        void UpdateUser(User user);
        void DeleteUser(User user);
        User GetUserByUserNameAndPassword(User user);


    }
}

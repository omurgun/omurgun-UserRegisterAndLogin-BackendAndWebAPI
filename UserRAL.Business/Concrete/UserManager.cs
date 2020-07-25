using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserRAL.Business.Abstract;
using UserRAL.Business.DependencyResolvers.Ninject;
using UserRAL.Business.FluentValidation;
using UserRAL.Business.Utilities;
using UserRAL.DataAccess.Abstract;
using UserRAL.Entities.Concrete;

namespace UserRAL.Business.Concrete
{
    public class UserManager : IUserService
    {
        private IUserDal _userDal;
        private IEncryptText _encryptText = InstanceFactory.GetInstance<IEncryptText>();
        private IValidationTool _validationTool = InstanceFactory.GetInstance<IValidationTool>();

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public List<User> GetAllUsers()
        {
            return _userDal.GetAll();
        }

        public List<User> GetUsersByRole(int roleId)
        {
            return _userDal.GetAll(x => x.RoleId == roleId);
        }

        public List<User> GetUsersByUserName(string userName)
        {
            return _userDal.GetAll(x => x.UserName.ToLower().Contains(userName.ToLower()));
        }

        public void AddUser(User user)
        {
            _validationTool.Validate(new UserValidator(), user);
            user.Key = Guid.NewGuid();
            user.RoleId = 2;
            user.Password = _encryptText.Sha384Enc(user.Password);
            _userDal.Add(user);
        }

        public void UpdateUser(User user)
        {
            _validationTool.Validate(new UserValidator(), user);
            _userDal.Update(user);
        }

        public void DeleteUser(User user)
        {
            _userDal.Delete(user);
        }

        public User GetUserByUserNameAndPassword(User user)
        {
            _validationTool.Validate(new UserLoginValidator(), user);
            return _userDal.Get(x => x.UserName.Equals(user.UserName) & x.Password.Equals(user.Password));
        }
    }
}

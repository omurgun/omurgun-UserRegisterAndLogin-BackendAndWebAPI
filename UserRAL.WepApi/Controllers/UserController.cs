using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using UserRAL.Business.Abstract;
using UserRAL.Business.DependencyResolvers.Ninject;
using UserRAL.Entities.Concrete;

namespace UserRAL.WepApi.Controllers
{
    public class UserController : ApiController
    {
        private IUserService _userService = InstanceFactory.GetInstance<IUserService>();

        [ResponseType(typeof(User))]
        public IHttpActionResult GetUserLogin(string userName, string password)
        {
            var user = _userService.GetUserByUserNameAndPassword(new User
            {
                UserName = userName,
                Password = password
            });

            if (user == null)
            {
                return NotFound();

            }
            else
            {
                return Ok(user);
            }

        }

        [ResponseType(typeof(User))]
        [HttpPost]
        public IHttpActionResult PostUserRegister(User user)
        {
            _userService.AddUser(user);
           return CreatedAtRoute("DefaultApi", new { id = user.Id }, user);

            //Request.CreateErrorResponse(HttpStatusCode.Created, "eklendi");

        }


    }
}

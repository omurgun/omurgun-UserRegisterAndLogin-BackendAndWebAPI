using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Claims;
using System.Security.Principal;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using UserRAL.Business.Abstract;
using UserRAL.Business.DependencyResolvers.Ninject;
using UserRAL.Entities.Concrete;

namespace UserRAL.WepApi.Security
{
    public class UserUserNameAndUserPasswordHandler : DelegatingHandler
    {
        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            var queryString = request.RequestUri.ParseQueryString();
            var UserUserName = queryString["Username"];
            var UserPassword = queryString["Password"];
            IUserService _userService = InstanceFactory.GetInstance<IUserService>();

            var user = _userService.GetUserByUserNameAndPassword(new User
            {
                UserName = UserUserName,
                Password = UserPassword
            });
            if (user != null)
            {
                var principal = new ClaimsPrincipal(new GenericIdentity(user.Name, "ApiKey"));
                HttpContext.Current.User = principal;
            }

            return base.SendAsync(request, cancellationToken);
        }
    }
}
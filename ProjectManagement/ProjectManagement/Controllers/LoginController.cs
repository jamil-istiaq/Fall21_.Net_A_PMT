using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Security;
using BusinessLayer;
using BusinessLayer.BEntaty;
using System.Web.Http.Cors;

namespace ProjectManagement.Controllers
{
    [EnableCors("*", "*", "*")]
    public class LoginController : ApiController
    {
        [Route("api/Project/log")]
        [HttpPost]
        public void GetLogin(string userId, string password)
        {

            var supervisor = SupService.GetLogin(userId, password);

            var member = MemService.GetLogin(userId, password);


            if (supervisor != null)
            {
                FormsAuthentication.SetAuthCookie(Convert.ToString(supervisor.Id), true);
            
            }

            else if (member != null)
            {
                FormsAuthentication.SetAuthCookie(member.User_Id, true);

            }
            
        }
    }
}

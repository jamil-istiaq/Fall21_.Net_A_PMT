using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BusinessLayer;
using BusinessLayer.BEntaty;
using System.Web.Http.Cors;

namespace ProjectManagement.Controllers
{
    [EnableCors("*", "*", "*")]
    public class SupController : ApiController
    {
        [Route("api/Project/sup")]
        [HttpGet]
 
         public List<Supervisor> Get()
         {
            return SupService.GetAll();
         }

        }
}

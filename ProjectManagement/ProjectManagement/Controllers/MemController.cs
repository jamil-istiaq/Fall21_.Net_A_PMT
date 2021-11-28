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
    public class MemController : ApiController
    {
      [Route("api/Project/mem")]
      [HttpGet]

      public List<Member> Get()
      {
        return MemService.GetAll();
       }

        }
}


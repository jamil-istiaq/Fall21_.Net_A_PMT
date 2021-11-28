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
    [EnableCors("*", "*","*")]
    public class ProjectController : ApiController
    {
        [Route("api/Project/all")]
        [HttpGet]
        public List<ProjectModel> Get()
        {
            return ProjectServices.GetAll();
        }

        [Route("api/Project/open")]
        [HttpGet]
        public List<ProjectModel> GetOpen()
        {
            return ProjectServices.GetOpen();
        }

        [Route("api/Project/complete")]
        [HttpGet]
        public List<ProjectModel> GetComplete()
        {
            return ProjectServices.GetComplete();
        }

        [Route("api/Project/inprocess")]
        [HttpGet]
        public List<ProjectModel> GetGetInpro()
        {
            return ProjectServices.GetInpro();
        }

        [Route("api/Project/Create")]
        [HttpPost]
        public void Add(ProjectModel s)
        {
            
            ProjectServices.Add(s);
        }

        [Route("api/Project/Apply")]
        [HttpPost]
        public void Add(ApplyModel s)
        {

            ApplyService.Add(s);
        }

        [Route("api/Project/Allapply")]
        [HttpPost]
        public List<ApplyModel>GetApply()
        {
            return ApplyService.GetAll();
        }
       

    }
}

using System.Collections.Generic;
using crowdfunding.Models;
using crowdfunding.Services;
using Microsoft.AspNetCore.Mvc;

namespace crowdfunding.Controllers
{
    [ApiController]
    [Route("api/backers")]
    public class BackerController : ControllerBase
    {
        private BackerService Service;

        public BackerController(BackerService service)
        {
            Service = service;
        }

        // GET api/backers
        [HttpGet]
        public ActionResult<List<Backer>> GetBackers()
        {
            return Ok(Service.All());
        }

        // POST api/backers
        [HttpPost]
        public ActionResult Create(Backer backer)
        {
            return Ok(Service.Create(backer));
        }
    }
}
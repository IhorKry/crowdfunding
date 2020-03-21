using System.Collections.Generic;
using crowdfunding.Models;
using crowdfunding.Services;
using Microsoft.AspNetCore.Mvc;

namespace crowdfunding.Controllers
{
    [ApiController]
    [Route("api/founders")]
    public class FounderController : ControllerBase
    {
        private FounderService Service;

        public FounderController(FounderService service)
        {
            Service = service;
        }

        // GET api/founders
        [HttpGet]
        public List<Founder> GetFounders()
        {
            return Service.All();
        }

        // GET api/founders/2
        [HttpGet("{id}")]
        public ActionResult<Founder> GetById(int id)
        {
            var result = Service.GetById(id);

            if (result == null) return NotFound();

            return Ok(result);
        }

        // GET api/founders/2/aims
        [HttpGet("{id}/aims")]
        public ActionResult GetAims(int id)
        {
            var founder = Service.GetById(id);

            if (founder == null) return NotFound();

            return Ok(Service.GetAims(id));
        }        

        // POST api/founders
        // [HttpPost]
        // public ActionResult Create(Founder founder)
        // {
        //     return Ok(Service.Create(founder));
        // }
    }
}
using System.Collections.Generic;
using crowdfunding.Models;
using crowdfunding.Services;
using Microsoft.AspNetCore.Mvc;

namespace crowdfunding.Controllers
{
    [ApiController]
    [Route("api/aims")]
    public class AimController : ControllerBase
    {
        private AimService Service;

        public AimController(AimService service)
        {
            Service = service;
        }

        // POST api/aims
        [HttpPost]
        public ActionResult Create(Aim aim)
        {
            return Ok(Service.Create(aim));
        }

        // TODO: Think about get all aims possibility 
        // GET api/aims
        [HttpGet]
        public List<Aim> GetAims()
        {
            return Service.All();
        }

        // GET api/aims/2
        [HttpGet("{id}")]
        public ActionResult<Aim> GetById(int id)
        {
            var result = Service.GetById(id);

            if (result == null) return NotFound();

            return Ok(result);
        }

        // TODO: Think about delete possibility 
        // DELETE api/aims/2
        [HttpDelete("{id}")]
        public ActionResult DeleteById(int id)
        {
            var result = Service.GetById(id);

            if (result == null) return NotFound();

            Service.Delete(result);
            return NoContent();
        }
    }
}
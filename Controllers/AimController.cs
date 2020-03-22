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
            bool isFounderExist = Service.IsFounderExist(aim.FounderId);
            if (!isFounderExist) return NotFound("founder not found");

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
            var aim = Service.GetById(id);

            if (aim == null) return NotFound();

            return Ok(aim);
        }

        // GET api/aims/2/report
        [HttpGet("{id}/report")]
        public ActionResult<AimReport> GenerateReport(int id)
        {
            var aim = Service.GetById(id);

            if (aim == null) return NotFound();

            return Ok(Service.GenerateReport(aim));
        }

        // TODO: Think about delete possibility 
        // DELETE api/aims/2
        [HttpDelete("{id}")]
        public ActionResult DeleteById(int id)
        {
            var aim = Service.GetById(id);

            if (aim == null) return NotFound();

            Service.Delete(aim);
            return NoContent();
        }
    }
}
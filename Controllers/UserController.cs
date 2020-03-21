using System.Collections.Generic;
using crowdfunding.Models;
using crowdfunding.Services;
using Microsoft.AspNetCore.Mvc;

namespace crowdfunding.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UserController : ControllerBase
    {
        private UserService Service;

        public UserController(UserService service)
        {
            Service = service;
        }

        // GET api/users
        [HttpGet]
        public ActionResult<List<User>> GetUsers()
        {
            return Ok(Service.All());
        }

        // POST api/users
        [HttpPost]
        public ActionResult Create(User user)
        {
            return Ok(Service.Create(user));
        }

        // PUT /api/users/2?activateFounder
        [HttpPut("{userId}")]
        public ActionResult<User> ActivateFounder(int userId)
        {
            var user = Service.GetById(userId);

            if (user == null) return NotFound();
            if (user.FounderId != 0) return BadRequest("User is already founder");

            return Ok(Service.ActivateFounder(user));
        }

    }
}
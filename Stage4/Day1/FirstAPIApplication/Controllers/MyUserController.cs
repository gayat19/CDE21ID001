using FirstAPIApplication.Models;
using FirstAPIApplication.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FirstAPIApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MyUserController : ControllerBase
    {
        private IRepo<User> _repo;

        public MyUserController(IRepo<User> repo)
        {
            _repo = repo;
        }
        // GET: api/<UserController>

        [HttpGet]
        public IActionResult Get()
        {
            var users = _repo.GetAll();
            if(users.Count >0)
                return Ok(users);
            return BadRequest("No Records found");
        }

        // GET api/<UserController>/5
        [Route("GetUserByID")]
        [HttpGet]
        public ActionResult<User> Get([FromBody]User givenUser)
        {
            var user = _repo.Get(givenUser.UserId);
            if (user == null)
                return BadRequest("No such User");
            return Ok(user);
        }

        // POST api/<UserController>
        [HttpPost]
        public IActionResult Post([FromBody] User user)
        {
            try
            {
                _repo.Add(user);
                return Ok("Regitered");
            }
            catch (Exception e)
            {
                return BadRequest("Could not register user");
            }
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

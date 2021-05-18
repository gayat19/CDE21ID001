using AuthenticationProject.Models;
using AuthenticationProject.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AuthenticationProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly WeatherContext _context;
        private readonly ITokenService<User> _tokenService;

        public UserController(WeatherContext context,ITokenService<User> tokenService)
        {
            _context = context;
            _tokenService = tokenService;
        }
        // GET: api/<UserController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<UserController>
        [Route("Register")]
        [HttpPost]
        public async Task<ActionResult<UserDto>> Register(string username,string password)
        {
            using var hmac = new HMACSHA512();
            var user = new User()
            {
                Username = username,
                Password = hmac.ComputeHash(Encoding.UTF8.GetBytes(password)),
                PasswordSalt = hmac.Key
            };
            _context.users.Add(user);
            await _context.SaveChangesAsync();

            var userDto = new UserDto()
            {
                Username = username,
                Token = _tokenService.CreateToken(user)
            };
            return userDto;
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

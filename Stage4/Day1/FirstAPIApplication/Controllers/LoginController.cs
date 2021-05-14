using FirstAPIApplication.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FirstAPIApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private CompanyContext _context;

        public LoginController(CompanyContext context)
        {
            _context = context;
        }
        [Route("Register")]
        [HttpPost]
        public async Task<ActionResult<User>> Register([FromBody] UserDTO user)
        {
            var hmac = new HMACSHA512();
            var dbUser = new User()
            {
                UserId = user.UserId,
                PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(user.Password)),
                PasswordSalt = hmac.Key
            };
            _context.Users.Add(dbUser);
            await _context.SaveChangesAsync();
            return dbUser;
        }
        [Route("Login")]
        [HttpPost]
        public async Task<ActionResult<User>> UserLogin([FromBody] UserDTO user)
        {
            var myUser = await _context.Users.SingleOrDefaultAsync(u => u.UserId == user.UserId);
            if (myUser == null)
                return Unauthorized("Invalid Username");
            var hmac = new HMACSHA512(myUser.PasswordSalt);
            var userPass = hmac.ComputeHash(Encoding.UTF8.GetBytes(user.Password));
            for (int i = 0; i < userPass.Length; i++)
            {
                if (userPass[i] != myUser.PasswordHash[i])
                    return Unauthorized("Invalid Password");
            }
            return myUser;
        }
    }
}

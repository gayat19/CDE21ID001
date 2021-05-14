using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstAPIApplication.Models
{
    public class UserDTO
    {
        public string UserId { get; set; }
        public string    Password { get; set; }
        public string Role { get; set; }
        public byte[] PasswordSalt { get; set; }
    }
}

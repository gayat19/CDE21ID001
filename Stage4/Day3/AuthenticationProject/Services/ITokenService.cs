using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthenticationProject.Services
{
    public interface ITokenService<T>
    {
        public string CreateToken(T t);
    }
}

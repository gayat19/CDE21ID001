using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerAPI.Services
{
    public interface IRepo<T>
    {
        List<T> GetAll();
        bool Add(T t);
    }
}

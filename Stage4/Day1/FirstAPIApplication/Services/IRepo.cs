using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstAPIApplication.Services
{
    public interface IRepo<T>
    {
        void Add(T t);
        T Get(string uid);
        ICollection<T> GetAll();

    }
}

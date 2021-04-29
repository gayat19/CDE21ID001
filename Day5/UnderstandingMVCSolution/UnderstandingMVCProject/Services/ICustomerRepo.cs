using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UnderstandingMVCProject.Services
{
    public interface ICustomerRepo<T>
    {
        void Add(T t);
        T GetById(int id);
        IEnumerable<T> GetAll();

        T EditCustomer(int id,T t);

    }
}

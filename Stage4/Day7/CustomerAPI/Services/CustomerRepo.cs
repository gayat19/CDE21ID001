using CustomerAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerAPI.Services
{
    public class CustomerRepo : IRepo<Customer>
    {
        private readonly CustomerContext _context;

        public CustomerRepo()
        {

        }
        public CustomerRepo(CustomerContext context)
        {
            _context = context;
        }
        public bool Add(Customer t)
        {
            try
            {
                _context.Customers.Add(t);
                _context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
           
        }

        public List<Customer> GetAll()
        {
            List<Customer> customers = _context.Customers.ToList();
            if (customers.Count == 0)
                return null;
            return customers;
        }
    }
}

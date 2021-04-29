using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnderstandingMVCProject.Models;

namespace UnderstandingMVCProject.Services
{
    public class CustomerRepo : ICustomerRepo<Customer>
    {
        List<Customer> customers = new List<Customer>();

        public void Add(Customer customer)
        {
            customers.Add(customer);
        }

        public IEnumerable<Customer> GetAll()
        {
            if (customers.Count == 0)
                throw new NoItemsExecptiion();
            return customers;
        }

        public Customer GetById(int id)
        {
            Customer customer = customers.FirstOrDefault(c => c.Id == id);
            return customer;
        }
    }
}

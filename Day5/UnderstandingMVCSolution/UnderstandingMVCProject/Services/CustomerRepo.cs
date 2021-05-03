using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnderstandingMVCProject.Models;

namespace UnderstandingMVCProject.Services
{
    public class CustomerRepo : ICustomerRepo<Customer>
    {
        public CustomerRepo()
        {

        }
        List<Customer> customers = new List<Customer>();
        protected CustomerContext _customerContext;

        //{
        //    new Customer(){Id=101,Name="Ramu",Phone="1234567890"},
        //    new Customer(){Id=102,Name="Somu",Phone="6789012345"}
        //};
        public CustomerRepo(CustomerContext customerContext)
        {
            _customerContext = customerContext;
        }
        public void Add(Customer customer)
        {
            //customers.Add(customer);
            _customerContext.Customers.Add(customer);
            _customerContext.SaveChanges();
        }

        public Customer EditCustomer(int id,Customer customer)
        {
           int myCustomer = customers.FindIndex(c => c.Id == id);
            if(myCustomer != -1)
            {
                customers[myCustomer] = customer;
                return customer;
            }
            return null;
        }

        public IEnumerable<Customer> GetAll()
        {
            //if (customers.Count == 0)
            //    throw new NoItemsExecptiion();
            //return customers;
            customers = _customerContext.Customers.ToList();
            if (customers.Count == 0)
                throw new NoItemsExecptiion();
            return customers;
        }

        public virtual Customer GetById(int id)
        {
            Customer customer = _customerContext.Customers.FirstOrDefault(c => c.Id == id);
            return customer;
        }

        //public bool Register(Customer t)
        //{
        //    throw new NotImplementedException();
        //}

        //public bool Login(Customer t)
        //{
        //    throw new NotImplementedException();
        //}
    }
    public class BankCustomerRepo:CustomerRepo 
    {
        public BankCustomerRepo(CustomerContext customerContext):base(customerContext)
        {

        }
        public override Customer GetById(int id)
        {
            Customer customer = _customerContext.Customers.FirstOrDefault(c => c.Id == id);
            return customer;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationForTesting
{
    public class Program
    {
        List<Customer> customers = new List<Customer>()
        {
            new Customer(101,"Ramu"),
            new Customer(102,"Somu")
        };

        public List<Customer> GetAllCustomers()
        {
            return customers;
        }
        public Customer GetCustomer(int Id)
        {
            Customer customer = customers.FirstOrDefault(c => c.Id == Id);
            if (customer == null)
                throw new NullReferenceException();
            return customer;
        }
        void PrintCustomers()
        {
            foreach (var item in customers)
            {
                Console.WriteLine(item);
            }
        }
        static void Main(string[] args)
        {
            new Program().PrintCustomers();
            Console.ReadKey();
        }
    }
}

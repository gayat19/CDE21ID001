using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationForTesting
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Customer()
        {

        }
        public Customer(int id,string name)
        {
            Id = id;
            Name = name;
        }
        public override string ToString()
        {
            return "Customer Id " + Id + "\nCustomer Name " + Name;
        }
    }
}

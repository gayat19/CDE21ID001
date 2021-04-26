using System;
using System.Collections.Generic;
using System.Linq;

namespace AssesmentQuestionProject
{
    class Employee
    {
        int id, age;
        string name;
        double salary;

        public Employee()
        {
        }
        public Employee(int id, int age, string name, double salary)
        {
            this.id = id;
            this.age = age;
            this.name = name;
            this.salary = salary;
        }

        public void TakeEmployeeDetailsFromUser()
        {
            Console.WriteLine("Please enter the employee ID");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the employee name");
            name = Console.ReadLine();
            Console.WriteLine("Please enter the employee age");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the employee salary");
            salary = Convert.ToDouble(Console.ReadLine());
        }

        public override string ToString()
        {
            return "Employee ID : " + id + "\nName : " + name + "\nAge : " + age + "\nSalary : " + salary;
        }

        //public int CompareTo(Employee obj)
        //{
        //    return this.salary.CompareTo(obj.salary);
        //}

        public int Id { get => id; set => id = value; }
        public int Age { get => age; set => age = value; }
        public string Name { get => name; set => name = value; }
        public double Salary { get => salary; set => salary = value; }
    }


    class Program
    {
        List<Employee> employees = new List<Employee>();
        void AddEmployees()
        {
            employees.Add(new Employee(101, 21, "Ramu", 1234567));
            employees.Add(new Employee(102, 21, "Somu", 34562));
           // employees.Sort();
            var sortedData = employees.OrderBy(e => e.Salary).ToList();
            foreach (Employee item in sortedData)
            {
                Console.WriteLine(item);
            }
        }
        static void Main(string[] args)
        {
            new Program().AddEmployees();
            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}

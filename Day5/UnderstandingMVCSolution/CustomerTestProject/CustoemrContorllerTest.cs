using Microsoft.EntityFrameworkCore;
using Moq;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using UnderstandingMVCProject;
using UnderstandingMVCProject.Controllers;
using UnderstandingMVCProject.Models;

namespace CustomerTestProject
{
    public class CustoemrContorllerTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestGetAllCustomers()
        {
            //Arrange
            //List of customers
            List<Customer> customers = new List<Customer>()
            {
                new Customer(){Id=101,Name="Ramu"},
                new Customer(){Id=102,Name="Somu"}
            };

            //Moq the DbSet
            var dbSetMoq = new Mock<DbSet<Customer>>();
            //setup the dbset
            var queriableCustomerList = customers.AsQueryable();
            dbSetMoq.As<IQueryable<Customer>>().Setup(cust => cust.Provider).Returns(queriableCustomerList.Provider);
            dbSetMoq.As<IQueryable<Customer>>().Setup(cust => cust.Expression).Returns(queriableCustomerList.Expression);
            dbSetMoq.As<IQueryable<Customer>>().Setup(cust => cust.ElementType).Returns(queriableCustomerList.ElementType);
            dbSetMoq.As<IQueryable<Customer>>().Setup(cust => cust.GetEnumerator()).Returns(queriableCustomerList.GetEnumerator());
            //Moq the context
            var moqContext = new Mock<CustomerContext>();
            moqContext.Setup(ctx => ctx.Customers).Returns(dbSetMoq.Object);

            //Action
            AnotherCustomerController customerController = new AnotherCustomerController(moqContext.Object);

            //Assert
            Assert.AreEqual("Somu", customerController.GetCustomers()[1].Name);
        }
    }
}
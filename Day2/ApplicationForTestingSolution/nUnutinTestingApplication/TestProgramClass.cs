using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApplicationForTesting;

namespace nUnutinTestingApplication
{
    [TestFixture]
    public class Class1
    {
        Program program;
        [SetUp]
        public void BaseWork()
        {
            program = new Program();
        }
        [Test]
        public void TestPositiveCusomerCount()
        {
            //action
            int count = program.GetAllCustomers().Count;
            //assert
            Assert.AreEqual(2, count);
        }
        [TestCase("Somu")]
        [TestCase("Ramu")]
        [TestCase("Ram")]
        public void TestCustomerName(string name)
        {
            //action
            string returnName = program.GetAllCustomers()[0].Name;
            Assert.AreEqual(name, returnName);
        }
    }
}

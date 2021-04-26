using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ApplicationForTesting;

namespace TestingProject
{
    [TestClass]
    public class ProgramTestClass
    {
        Program program;
        [TestInitialize]
        public void  TestInit()
        {
            program = new Program();
        }
        [TestMethod]
        public void TestCountGetAllCustomersPositive()
        {
            //Arrange
            //Program program = new Program();
            //Act
            int count = program.GetAllCustomers().Count;
            //Assert
            Assert.AreEqual(2, count);
        }
        [TestMethod]
        public void TestGetAllCustomersNegative()
        {
            //Arrange
            //Program program = new Program();
            //Act
            string customerName = program.GetAllCustomers()[0].Name;
            //Assert
            Assert.AreEqual("Ram",customerName );
        }
        [TestCleanup]
        public void AfterTest()
        {
            program = null;
        }
    }
}

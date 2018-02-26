using Microsoft.VisualStudio.TestTools.UnitTesting;
using Acme.Biz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Biz.Tests
{
    [TestClass()]
    public class ProductTests
    {
        [TestMethod()]
        public void SayHelloTest()
        {
            //Arrange
            var productTest = new Product();
            productTest.ProductName = "Zoom10";
            productTest.ProductID = 1;
            productTest.Description = "This is a Nike 10 Size Shoes,Model Zoom";

            //Act
            string expected = "Hello Zoom10 (1): This is a Nike 10 Size Shoes,Model Zoom";
            var actual=productTest.SayHello();
            //Assert
            Assert.AreEqual(actual,expected);
        }
    }
}
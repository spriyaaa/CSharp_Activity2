using Microsoft.VisualStudio.TestTools.UnitTesting;
using Activity2BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity2BL.Tests
{
    [TestClass()]
    public class ProductTests
    {
        [TestMethod()]
        public void ProductTest()
        {

        }

        [TestMethod()]
        public void ProductTest1()
        {
            {
                Product pr1 = new Product("Puma Shoes", "shoes", 1200);
                Product pr2 = new Product("Appli iPhone", "mobile phone", 1000);

                Assert.AreNotSame(pr1,pr2);
            }

        }
    }
}
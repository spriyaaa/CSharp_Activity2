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
    public class SellerTests
    {
        [TestMethod()]
        public void SellerTest()
        {

        }

        [TestMethod()]
        public void SellerTest1()
        {
            {
                Seller s1 = new Seller("simran");
                Seller s2= new Seller("priya");
                Assert.AreNotSame(s1, s2);
            }

        }
    }
}
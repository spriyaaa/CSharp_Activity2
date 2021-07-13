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
    public class CustomerTests
    {
        [TestMethod()]
        public void CustomerTest()
        {

        }

        [TestMethod()]
        public void CustomerTest1()
        {
            {
                DateTime dt1 = new DateTime(1991, 07, 07);
            
                Customer c1 = new Customer("simran", "kochi", dt1, "s@ltts.com", Gender.Female, "star34", CustomerType.EliteCustomer);

                Customer c2= new Customer("soumya", "kochi", dt1, "so@ltts.com", Gender.Female, "star56", CustomerType.PrivilegedCustomer);
                Assert.AreNotSame(c1, c2);

               

            }

        }

        [TestMethod()]
        public void GetDiscountTest()
        {

        }
    }
}
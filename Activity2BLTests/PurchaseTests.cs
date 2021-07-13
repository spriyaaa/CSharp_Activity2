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
    public class PurchaseTests
    {
        [TestMethod()]
        public void CalculateBillAmountTest()
        {


        }

        [TestMethod()]
        public void CalculateBillAmountTest1()
        {

        }

        [TestMethod()]
        public void PurchaseTest()
        {

        }

        [TestMethod()]
        public void PurchaseTest1()
        {
            {
                DateTime dt1 = new DateTime(2021, 07, 10);
                Purchase p1 = new Purchase(7, "patna", dt1, "Cash");

                DateTime dt2 = new DateTime(2021, 07, 10);
                Purchase p2 = new Purchase(20, "kochi", dt2, "debit");

                Assert.AreNotSame(p1, p2);
            }


        }

        [TestMethod()]
        public void RoundOffBillTest1()
        {
            double actual = Purchase.RoundOffBill(98.897);
            double expected = 98.90;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetPurchasePercentageTest()
        {

        }
    }
}
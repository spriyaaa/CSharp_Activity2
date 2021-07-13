using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Activity2BL
{
    public class Seller
    {
        private string sellerId;
        //private int sellerIdCount;
        public static int sellerIdCount;
        private string sellerName;


        public string SellerId { get; set; }
        public string[] SellerLocations { get; set; }
        public string SellerName { get; set; }


        static Seller()
        {
            sellerIdCount = 1001;
        }

        public Seller()
        {
            SellerId = "S" + sellerIdCount.ToString();
            sellerIdCount++;
        }

        public Seller(string sellerName)
        {

        }
    }
}
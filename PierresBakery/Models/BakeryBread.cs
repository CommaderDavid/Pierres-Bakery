using System.Collections.Generic;
using System;

namespace PierresBakery.Models
{
    public class BakeryBread
    {
        public string UserOrder { get; set; }
        public int OrderNumber { get; set; }

        public static Dictionary<string, int> breadPrice = new Dictionary<string, int> ()
        {
            { "bread", 5 }
        };

        public BakeryBread(string userOrder, int orderNumber)
        {
            UserOrder = userOrder;
            OrderNumber = orderNumber;
        }

        public int BreadTotalPrice(string food, int totalWant)
        {
            int total = 0;
            
            total += breadPrice[food];

            total *= totalWant;

            return total;
        }
    }
}
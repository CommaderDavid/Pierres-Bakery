using System.Collections.Generic;
using System;

namespace PierresBakery.Models 
{
    public class BakeryPastry 
    {
        public string UserOrder { get; set; }
        public int OrderNumber { get; set; }

        public static Dictionary<string, int> pastryPrice = new Dictionary<string, int>()
        {
            { "pastry", 2 }
        };

        public BakeryPastry(string userOrder, int orderNumber)
        {
            UserOrder = userOrder;
            OrderNumber = orderNumber;
        }

        public int PastryTotalPrice(string food, int totalWant)
        {
            int total = 0;

            total += pastryPrice[food];

            total *= totalWant;

            return total;
        }
    }
}
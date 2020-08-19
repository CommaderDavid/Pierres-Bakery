using System.Collections.Generic;
using System;

namespace PierresBakery.Models 
{
    public class BakeryPastry 
    {
        public string UserOrder { get; set; }
        public static Dictionary<string, int> pastryPrice = new Dictionary<string, int>()
        {
            { "pastry", 2 }
        };

        public BakeryPastry(string userOrder)
        {
            UserOrder = userOrder;
        }

        public int PastryTotalPrice(string food)
        {
            return pastryPrice[food];
        }
    }
}
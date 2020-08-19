using System.Collections.Generic;
using System;

namespace PierresBakery.Models
{
    public class BakeryBread
    {
        public string UserOrder { get; set; }
        public static Dictionary<string, int> breadPrice = new Dictionary<string, int> ()
        {
            { "bread", 5 }
        };

        public BakeryBread(string userOrder)
        {
            UserOrder = userOrder;
        }

        public int BreadTotalPrice(string food)
        {
            return breadPrice[food];
        }
    }
}
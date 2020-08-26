using System.Collections.Generic;
using System;

namespace PierresBakery.Models
{
    public class Bread
    {
        public string UserOrder { get; set; }
        public int OrderNumber { get; set; }

        public static Dictionary<string, int> breadPrice = new Dictionary<string, int> ()
        {
            { "bread", 5 }
        };

        public Bread(string userOrder, int orderNumber)
        {
            UserOrder = userOrder;
            OrderNumber = orderNumber;
            _instance.Add(this);
        }

        public int BreadTotalPrice(string food, int totalWant)
        {
            int total = 0;
            total = (totalWant / 2) * breadPrice[food];
            if (totalWant % 2 == 0)
            {
                return total;
            }
            else
            {
                total += breadPrice[food];
                return total;
            }
        }
    }
}
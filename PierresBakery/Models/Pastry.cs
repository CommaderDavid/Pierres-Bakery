using System.Collections.Generic;
using System;

namespace PierresBakery.Models 
{
    public class Pastry 
    {
        public string UserOrder { get; set; }
        public int OrderNumber { get; set; }
        public static int DealOrder { get; } = 5;   // static property available to all pastry object
        public static int Total { get; set; } = 0;

        public static Dictionary<string, int> pastryPrice = new Dictionary<string, int>()
        {
            { "pastry", 2 }
        };

        public Pastry(string userOrder, int orderNumber)
        {
            UserOrder = userOrder;
            OrderNumber = orderNumber;
            Total += PastryTotalPrice(userOrder, orderNumber);   //this adds the current order's total to the entire total of all pastrys
        }

        public int PastryTotalPrice(string food, int totalWant)
        {
            int total = 0;
            total = (totalWant / 3) * DealOrder;
            if (totalWant % 3 == 0)
            {
                return total;
            }
            else
            {
                total += (totalWant % 3) * pastryPrice[food];
                return total;
            }
        }
    }
}
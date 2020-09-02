using System.Collections.Generic;
using System;

namespace PierresBakery.Models 
{
    public class Pastry 
    {
        public string UserOrder { get; set; }
        public int OrderNumber { get; set; }
        public static int DealOrder { get; } = 5;   // static property available to all pastry object
        public static int TotalOrdered { get; set; } = 0;

        public static Dictionary<string, int> pastryPrice = new Dictionary<string, int>()
        {
            { "pastry", 2 }
        };

        public Pastry(string userOrder, int orderNumber)
        {
            UserOrder = userOrder;
            OrderNumber = orderNumber;
            TotalOrdered += orderNumber;   //this adds the current order's total to the entire total of all pastrys
        }

        public static void ClearAll()
        {
            TotalOrdered = 0;
        }

        public static int PastryTotalPrice()
        {
            string food = "pastry";
            int total = 0;
            total = (TotalOrdered / 3) * DealOrder;
            if (TotalOrdered % 3 == 0)
            {
                return total;
            }
            else
            {
                total += (TotalOrdered % 3) * pastryPrice[food];
                return total;
            }
        }
    }
}
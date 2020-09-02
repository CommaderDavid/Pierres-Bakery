using System.Collections.Generic;
using System;

namespace PierresBakery.Models
{
    public class Bread
    {
        public string UserOrder { get; set; }
        public int OrderNumber { get; set; }
        public static int TotalOrdered { get; set; } = 0;   // mainting a total of all ordered bread

        public static Dictionary<string, int> breadPrice = new Dictionary<string, int> ()
        {
            { "bread", 5 }
        };

        public Bread(string userOrder, int orderNumber)
        {
            UserOrder = userOrder;
            OrderNumber = orderNumber;
            TotalOrdered += orderNumber;   //this adds the current order's total to the entire total of all breads
        }

        public static void ClearAll()
        {
            TotalOrdered = 0;
        }

        public static int BreadTotalPrice()
        {
            string food = "bread";
            int total = 0;
            total = (TotalOrdered / 3) * (breadPrice[food] * 2);
            if (TotalOrdered % 3 == 0)
            {
                return total;
            }
            else
            {
                total += (breadPrice[food] * (TotalOrdered % 3));
                return total;
            }
        }
    }
}
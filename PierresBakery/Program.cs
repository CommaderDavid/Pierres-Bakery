using System.Collections.Generic;
using System;
using PierresBakery.Models;

namespace PierresBakery 
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("Welcome to Pierre's Bakery!");
            Console.WriteLine("Bread is $5 per loaf.");
            Console.WriteLine("Pastrys are $2 each.");
            Console.WriteLine("------------------------------");
            Console.WriteLine("We have 2 deals:");
            Console.WriteLine("Bread: Buy 2 get 1 free");
            Console.WriteLine("Pastry: Buy 3 for $5");
            Console.WriteLine("------------------------------");
            Console.WriteLine("What would you like to do: ['order' / 'view']");
            string userDesition = Console.ReadLine().ToLower();
            if (userDesition == "order")
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine("Which would you like to order: [Bread / Pastry]");
                string type = Console.ReadLine().ToLower();
                if (type == "bread")
                {
                    Console.WriteLine("How many loaves do you want to order?");
                    int numberBread = int.Parse(Console.ReadLine());
                    Bread userBread = new Bread(type, numberBread);
                    Console.WriteLine("Order received");
                    Main();
                }
                else if (type == "pastry")
                {
                    Console.WriteLine("How many pastrys do you want to order?");
                    int numberPastry = int.Parse(Console.ReadLine());
                    Pastry userPastry = new Pastry(type, numberPastry);
                    Console.WriteLine("Order received");
                    Main();
                }
            }
            else if (userDesition == "view")
            {
                Console.WriteLine("Your order of bread is $" + Bread.BreadTotalPrice());
                Console.WriteLine("Your order of pastrys is $" + Pastry.PastryTotalPrice());
            }
        }
    }
}
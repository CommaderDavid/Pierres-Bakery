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
            Console.WriteLine("Which would you like to order: [b for Bread / p for Pastry]");
            string type = Console.ReadLine().ToLower();
            if (type == "b")
            {
                Console.WriteLine("How many do you want to order?");
                Console.ReadLine();
                Bread userBread = new Bread();
            }
        }
    }
}
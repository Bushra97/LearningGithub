using System;
using System.Collections.Generic;
using System.Text;

namespace Day_1_Console
{
    class DEMO1
    {
        public static void Main()
        {
            //creating variables
            string mobile_model;
            double price;
            int qty;

            //taking input by default its string
            Console.WriteLine("Enter mobile model: ");
            mobile_model = Console.ReadLine();
            Console.WriteLine("Enter mobile price: ");
            price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter mobile quantity: ");
            qty = Convert.ToInt32(Console.ReadLine());

            //printing to the screen
            Console.WriteLine("The details are {0}, {1}, {2}", mobile_model,price, qty );
            Console.ReadLine();
        }
    }
}

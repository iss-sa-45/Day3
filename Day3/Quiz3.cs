using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class Quiz3
    {
        static void Main(string[] args)
        {
            double gadgetPrice = 500;
            Console.WriteLine("Welcome to ISS Gadget Shop");

            Console.Write("Number of items to purchase: ");
            int qty = Int32.Parse(Console.ReadLine());

            double discount = 0;
            double total = qty * gadgetPrice;

            if (total <= 3000)
            {
                if (total <= 2000)
                {
                    discount = 0;
                } else
                {
                    discount = 0.03; // total = total * 0.97;
                }
            } else if (total <= 6000)
            {
                discount = 0.05; // total = total * 0.95;
            } else
            {
                discount = 0.08; // total = total * 0.92;
            }

            total = total * (1 - discount);

            Console.WriteLine("Please pay {0:c}", total);
        }
    }
}

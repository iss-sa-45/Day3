using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class Program5
    {
        static void Main()
        {
            Random r = new Random(); //creating a new Random object
            for (int i = 0; i < 10; i++)
            {
                int value = r.Next(0,100); //0-99
                Console.WriteLine(value);
            }

        }
    }
}

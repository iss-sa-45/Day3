using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class Program2
    {
        static void Main()
        {
            // first, we declare a new variable i, initialize with 0
            // as long as i<10 we will repeat
            // at the end of every repetition we will do i++
            for (int i = 1; i < 10; i = i + i)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("----------");

            for (int i = 10; i >= 0; i = i - 2)
            {
                Console.WriteLine(i);
            }

            for (string s = ""; s.Length<10; s = s + "*")
            {
                Console.WriteLine(s);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class Program1
    {
        static void Main()
        {
            // first, we declare a new variable i, initialize with 0
            // as long as i<10 we will repeat
            // at the end of every repetition we will do i++
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }


            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}

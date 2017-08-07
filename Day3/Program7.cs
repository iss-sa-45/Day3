using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class Program7
    {
        static void Main()
        {
            Console.WriteLine("abc".CompareTo("xyz")); // -1
            Console.WriteLine("ABC".CompareTo("xyz")); // -1
            Console.WriteLine("abc".CompareTo("XYZ")); // -1
            Console.WriteLine("abc".CompareTo("ABC")); // -1
            Console.WriteLine("abc".CompareTo("abc")); // 0
            Console.WriteLine("ABC".CompareTo("abc")); // 1
            Console.WriteLine("ABC".CompareTo(1)); // error
        }
    }
}

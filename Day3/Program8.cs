using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class Program8
    {
        public static void MainMethod()
        {
            string s = "$%$$abc%s%$";
            char[] c = new char[] { '$', '%' ,'a'};
            Console.WriteLine("*" + s + "*");
            string r = s.Trim(c);
            Console.WriteLine("*" + r + "*");
            Console.WriteLine(c);

            Console.WriteLine("   ".Length);
            s = "Institute Systems Science";
            Console.WriteLine(s.Insert(10, "of "));

            s = s.Insert(10, "of ");
            s = s.Insert(10, "of ");
            Console.WriteLine(s);

            s = "ABC";
            r = s.PadLeft(7, 'c');
            Console.WriteLine(s);
            Console.WriteLine(r);
            Console.WriteLine(s.PadRight(6,'z'));

        }
    }
}

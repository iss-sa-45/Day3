using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class Program9
    {
        public static void MainMethod()
        {
            string a = "Institute  of Systems Science";
            string[] s = a.Split(' ');
            //for (int i = 0; i <= s.Length - 1; i++)
            //    Console.WriteLine(s[i]);

            a = "Institute%of Systems%Science";
            char[] chars = new char[] { ' ', 'i', '%' };
            //s = a.Split(chars);
            s = a.Split(new char[] { ' ', 'i', '%' });
            for (int i = 0; i <= s.Length - 1; i++)
                Console.WriteLine(s[i]);

            a = "I\tme\tand myself";
            chars = new char[] { ' ', 'i', '%' };
            s = a.Split('\t');
            for (int i = 0; i <= s.Length - 1; i++)
                Console.WriteLine(s[i]);
        }
    }
}

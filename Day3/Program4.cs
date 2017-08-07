using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class Program4
    {
        static void Main()
        {
            bool isParsable = false; //doesn't matter whether true or false
            bool hasEnterSomething = false;
            int value=0;

            //while (user hasn't entered a number)
            while ((hasEnterSomething==false) || (isParsable == false))
            { 
            //{
                //if this this is the first time
                if (hasEnterSomething ==false)
                {
                    //ask user politely for a number
                    Console.Write("Please enter an integer: ");
                } else
                {
                    //ask with a different message
                    Console.Write("You didn't enter an integer. Please enter an integer: ");
                }
                string input = Console.ReadLine();

                hasEnterSomething = true;

                isParsable = Int32.TryParse(input, out value);
                //}
            }

            // at this point, we know user has entered an integer
            Console.WriteLine("The value that you've entered is {0}", value);
        }
    }
}

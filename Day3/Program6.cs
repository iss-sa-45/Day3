using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class Program6
    {
        static void Main()
        {
            //pick a random number
            Random r = new Random();
            int secret = r.Next(0, 10); //0-9

            bool correctGuess = false;
            //do {
            do
            {
                //  ask user for a guess
                Console.Write("Please guess (0-9): ");
                int guess = Int32.Parse(Console.ReadLine());

                if (secret == guess)
                {
                    correctGuess = true;
                }

            } while (correctGuess == false); // !correctGuess
            //} while (user hasn't guess the number)

            //exit? user guess correctly
            //congratulate the user
            Console.WriteLine("Congratulations, you have guessed it correctly.");
        }
    }
}

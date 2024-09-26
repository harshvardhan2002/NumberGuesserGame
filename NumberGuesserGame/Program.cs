using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuesserGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int secretNumber, guessingNumber;

            Console.WriteLine("Enter the secret number: ");
            secretNumber =Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Range set by game master is 1-100");
            Console.WriteLine("Guess the number: ");
            guessingNumber = Convert.ToInt32(Console.ReadLine());

            while (guessingNumber != secretNumber)
            {
                if (guessingNumber < secretNumber) Console.WriteLine("The number is too low, You lost!");
                else Console.WriteLine("The number is too high, You lost!");

                Console.WriteLine("Guess the number again!");
                guessingNumber=Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("Congrats! The number is right!");
        }
    }
}

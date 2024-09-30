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
            
            int minRange, maxRange;

            Console.WriteLine("Enter the minimum range: ");
            minRange = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the maximum range: ");
            maxRange = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the secret number: (within the range)");
            secretNumber =Convert.ToInt32(Console.ReadLine());

            NumberGuesser numberGuesser = new NumberGuesser(minRange, maxRange, secretNumber);

            numberGuesser.StartGuessing();
        }
    }
}

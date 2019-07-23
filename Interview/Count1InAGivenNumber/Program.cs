using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count1InAGivenNumber
{
    /// <summary>
    /// Count number of 1 in a given number
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter a number:");
                int number = Int32.Parse(Console.ReadLine());

                int rem = 0; int count = 0;
                int original = number;
                while (number > 0)
                {
                    rem = number % 2;
                    count += rem;

                    number = number / 2;
                }

                Console.WriteLine($"Number {original} has {count} of 1.");
            }
        }
    }
}

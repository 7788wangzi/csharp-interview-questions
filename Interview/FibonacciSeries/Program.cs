using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSeries
{
    /// <summary>
    /// 0, 1, 1, 2, 3, 5, 8, 13, 21
    /// </summary>
    class Program 
    {
        static void Main(string[] args)
        {
            int num1 = 0, num2 = 1;
            int num;
            int number = 0;
            Console.WriteLine("Enter how many digits to output: ");
            number = Convert.ToInt32(Console.ReadLine());

            Console.Write($"{num1} {num2} ");
            while(number>2)
            {
                num = num1 + num2;
                Console.Write($"{num} ");                
                num1 = num2;
                num2 = num;
                number--;
            }

            Console.ReadKey();

        }
    }
}

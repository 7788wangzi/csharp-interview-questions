using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmstrongNumber
{
    /// <summary>
    /// 153 = 1*1*1+5*5*5+3*3*3
    /// 371 = 3*3*3+7*7*7+1*1*1
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int num = 153;
            int reNum = 0, rem = 0;
            Console.WriteLine("Enter a digit number: ");
            num = Convert.ToInt32(Console.ReadLine());

            // num is going to be desctructed, save it to a temp variable first.
            int temp = num;
            while(num>0)
            {
                // get the individual digit number from right to left
                rem = num % 10;
                // construct a new number with each digit multiple itself three times.
                reNum = reNum + rem * rem * rem;
                num = num / 10;
            }

            if(temp == reNum)
            {
                Console.WriteLine($"{temp} is a ArmstrongNumber");
            }
            else
            {
                Console.WriteLine($"{temp} is NOT a ArmstrongNumber");
            }
            Console.ReadLine();
        }
    }
}

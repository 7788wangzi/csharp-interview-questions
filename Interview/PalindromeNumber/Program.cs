using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeNumber
{
    /// <summary>
    /// e.g.
    /// <=>
    /// 1
    /// <==>
    /// 11
    /// 22
    /// <===>
    /// 121
    /// 232
    /// <====>
    /// 1221
    /// 2332
    /// </summary>
    class Program 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");

            int num = Convert.ToInt32(Console.ReadLine());

            // num is going to be desctructed, save it to a temp variable first.
            int temp = num;
            int reNum=0, rem = 0;
            while(num>0)
            {
                // get the individual digit number from right to left
                rem = num % 10;
                // construct a new number with each digit multiple 10 and then add the next right one.
                reNum = reNum * 10 + rem;
                num = num / 10;
            }

            if(temp==reNum)
            {
                Console.WriteLine($"{temp} is a Palindrome number.");
            }
            else
            {
                Console.WriteLine($"{temp} is NOT a Palindrome number.");
            }

            Console.Read();
        }
    }
}

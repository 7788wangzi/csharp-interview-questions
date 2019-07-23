using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find2ndMaximumNumberInGivenArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = { 3, 23, 12, 34, 25 };

            int max1, max2;
            max1 = max2 = input[0];
            for(int i=1; i<input.Length; i++)
            {
                if(input[i]>max1)
                {
                    max2 = max1;
                    max1 = input[i];
                    continue;
                }
                else if (input[i] > max2)
                {
                    max2 = input[i];
                }
            }

            Console.WriteLine($"Max: {max1}; 2nd Max: {max2}");
            Console.ReadKey();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapTwoNumberWithoutAThirdVar
{
    /// <summary>
    /// a = 10, b = 25
    /// =>
    /// a = 25, b = 10
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 25;
            Console.WriteLine($"Before Swap, the values are: a = {a} ; b = {b}");

            a = a + b; // a1 = a0 + b0; b0 = b0;
            b = a - b; // a1 - b0 = a0, then assign to b1
            a = a - b; // a1 = a0 + b0; b1 = a0; a1-b1 = b0, then assign to a1

            Console.WriteLine($"After Swap, the values are: a = {a} ; b = {b}");
            Console.ReadKey();
        }
    }
}

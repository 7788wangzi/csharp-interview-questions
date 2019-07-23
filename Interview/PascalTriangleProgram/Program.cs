using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PascalTriangleProgram
{
    /// <summary>
    /// row
    ///     1
    ///    1 1
    ///   1 2 1
    ///  1 3 3 1
    /// 1 4 6 4 1
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int row = 5;
            int current = 1;
            //while(current<=5)
            //{
            //    for(int i=0; i<row-current; i++)
            //    {
            //        Console.Write(" ");
            //    }

            //    for(int i=1; i<=current;i++)
            //    {
            //        Console.Write("A ");
            //    }
            //    Console.WriteLine();

            //    current++;
            //}

            for(int i=0; i<row;i++)
            {
                for(int j=0; j<(row-i); j++)
                {
                    Console.Write(" ");
                }
                int value = 1;
                for(int j=0; j<=i; j++)
                {
                    Console.Write($"{value} ");
                    value = value * (i - j) / (j + 1);                    
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}

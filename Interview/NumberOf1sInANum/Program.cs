using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberOf1sInANum
{
    /// <summary>
    /// 0101 & 0001 = 0001
    /// 0101 & 0010 = 0000
    /// 0101 & 0100 = 0100
    /// 0101 & 1000 = 0000
    /// 
    /// 0001 <<1 = 0010
    /// 0010 <<1 = 0100
    /// 0100 <<1 = 1000
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int num = 7;

            int iter = 1;
            int count = 0;

            for (int i = 0; i < 32; i++)
            {
                if ((num & iter) == iter)
                {
                    count++;
                }

                iter = iter << 1;
            }

            Console.WriteLine($"number of 1s in {num} is {count}");
            Console.ReadLine();
        }
    }
}

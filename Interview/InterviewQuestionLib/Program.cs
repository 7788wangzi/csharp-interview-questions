using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestionLib
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 7;

            int iter = 1;
            int count = 0;

            for(int i=0; i<32; i++)
            {
                if((num&iter)==iter)
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlphabeticalOrderString
{
    /// <summary>
    /// Hello -> ehllo
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            string inputStr = "Hello";

            Console.WriteLine("Enter a word: ");
            inputStr = Console.ReadLine();

            char[] strArray = inputStr.ToLower().ToArray();            
            int length = strArray.Length;
            Console.Write("Before sort:" );
            for(int i=0; i<length; i++)
            {
                Console.Write($"{strArray[i]} ");
            }
            // bubble sort 冒泡排序
            for(int i=0; i<length-1;i++)
            {
                for(int j=i+1; j<length-i; j++)
                {
                    if(strArray[i]>strArray[j])
                    {
                        char temp = strArray[j];
                        strArray[j] = strArray[i];
                        strArray[i] = temp;
                    }
                }
            }
            Console.WriteLine();
            Console.Write("After sort:");
            for (int i = 0; i < length; i++)
            {
                Console.Write($"{strArray[i]} ");
            }

            Console.ReadKey();
        }
    }
}

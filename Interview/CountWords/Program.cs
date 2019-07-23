using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountWords
{
    /// <summary>
    /// Hello my dear dog
    /// -> 4 words
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sentence without punctuation: ");
            string input = Console.ReadLine();

            char[] characters = input.Trim().ToCharArray();
            int wordCount = 1;
            char lastChar=characters[0];
            for(int i = 0; i< characters.Length; i++)
            {
                if(characters[i]==' '|| characters[i] == '\t'|| characters[i]=='\r'|| characters[i]=='\n')
                {
                    if (characters[i] == lastChar)
                        continue;
                    wordCount++;
                }
                lastChar = characters[i];
            }

            Console.WriteLine($"Words: {wordCount}");
            Console.ReadKey();
        }
    }
}

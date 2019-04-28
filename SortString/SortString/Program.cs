using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortString
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string sentence = "I am so happy to finally study .NET and specifically C#";
            Console.WriteLine("Original Text:" +"\n" + sentence + "\n");

            string[] individualWords = sentence.Split(' ');
            Console.WriteLine("Split String in Array:");
            foreach (string word in individualWords)
            {
                Console.WriteLine(word);
            }
            Console.WriteLine("\n");

            Array.Sort(individualWords);
            Console.WriteLine("Sorted Array:");
            foreach (string word in individualWords)
            {
                Console.WriteLine(word);
            }
            Console.WriteLine("\n");

            string finalOutput = string.Join(" ", individualWords);
            Console.WriteLine("Concatanated Ordered String:" + "\n" + finalOutput + "\n");
            Console.ReadKey();

        }
    }
}

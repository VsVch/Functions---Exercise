using System;
using System.Linq;

namespace _06._Middle_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();


            Chars(word);
            
        }

        private static void Chars(string input)
        {
            


            if (input.Length % 2 == 0)
            {
               
                Console.Write(input[(input.Length / 2) - 1]);
                Console.Write(input[input.Length / 2]);
            }
            else
            {

                Console.Write(input[(input.Length / 2)]);
                
            }

            Console.WriteLine();
            

        }
    }
}

using System;

namespace _03._Characters_in_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());

            AllChars(first, second);
            
        }
        static void AllChars(char first, char second)
        {


            int startChar = Math.Min(first, second);
            int endChar = Math.Max(first, second);
            for (int i = startChar + 1; i < endChar; i++)
            {
                Console.Write((char)i + " ");
            }
        }
    }
}

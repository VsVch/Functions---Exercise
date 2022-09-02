using System;

namespace _02._Vowels_Count
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            NumVolwes(input);
        }
        static void NumVolwes(string input)
        {
            int count = 0;
            input = input.ToLower();
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 'a' || input[i] == 'y' || input[i] == 'o' || input[i] == 'u' || input[i] == 'e' || input[i] == 'i')
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}

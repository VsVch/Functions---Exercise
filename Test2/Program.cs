using System;

namespace Test2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int count = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 'a' || input[i] == 'y' || input[i] == 'o' || input[i] == 'u' || input[i] == 'e' || input[i] == 'i')
                {
                    count++;
                }
            }
        }
    }
}

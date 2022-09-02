using System;

namespace _09._Palindrome_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            while (input != "END")
            {


                bool isPalindrome = Palindrome(input);
                Console.WriteLine(isPalindrome.ToString().ToLower());
                input = Console.ReadLine();
            }
        }

        private static bool Palindrome(string input)
        {
            int number = int.Parse(input);
            bool isPalind = false;
            string first = string.Empty;
            string second = string.Empty;

            if (number >=0 && number <= 9)
            {
                isPalind = true;
            }
            for (int i = 0; i <= input.Length/2; i++)
            {
                first += input[i];
                
                
            }

            if (input.Length % 2 == 0)
            {
                for (int j = input.Length - 1; j >= input.Length / 2 - 1; j--)
                {
                    second += input[j];
                }
            }
            else
            {
                for (int j = input.Length - 1; j >= input.Length / 2; j--)
                {
                    second += input[j];
                }
            }



            
            if (first == second)
            {
                isPalind = true;
            }
            
            return isPalind;
        }
    }
}

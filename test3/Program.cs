﻿using System;

namespace _06._Middle_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();


            Chars(input);

        }

        private static void Chars(string input)
        {



            if (input.Length % 2 == 0)
            {
                Console.WriteLine(input[input.Length / 2 - 1]);
                Console.WriteLine(input[input.Length / 2 - 1]);
            }
            else
            {

                Console.WriteLine(input[input.Length / 2]);

            }




        }
    }
}

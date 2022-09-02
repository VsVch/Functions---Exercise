using System;
using System.Linq;

namespace _08._Factorial_Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());


            double facturiel1 = Facturiel(num1);
            double facturiel2 = Facturiel(num2);

            double result = facturiel1 / facturiel2;
            Console.WriteLine($"{result:f2}");




        }

        private static double Facturiel(int number)
        {
            double result = 1.0;
            while (number != 1)
            {
                result *= number;
                number--;
            }
            return result;
        }
    }
}

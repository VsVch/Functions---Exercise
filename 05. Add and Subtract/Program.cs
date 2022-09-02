using System;

namespace _05._Add_and_Subtract
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int result1 = SUM(num1, num2);

            int result2 = Subst(result1, num3);
            Console.WriteLine(result2);
        }

        private static int Subst(int result1, int num3)
        {
            int result2 = result1 - num3;
            return result2;
        }

        private static int SUM(int num1, int num2)
        {
            int result1 = num1 + num2;
            return result1;
        }
    }
}

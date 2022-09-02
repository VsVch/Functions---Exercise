using System;

namespace _01._Smallest_of_Three_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());

            Console.WriteLine(SmallastNumber(first, second, third)); 


        }

        static int SmallastNumber(int first, int second, int third)
        {
            if (first < second && first < third)
            {
               
                return first;
            }
            if (second < first && second < third)
            {
                
                return second;
            }
            if (first > third && first > third)
            {
                
                return third;
            }

            return first;
        }

    }
}

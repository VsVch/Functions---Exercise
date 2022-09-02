using System;
using System.Linq;

namespace _04._Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            bool isCharactersBetweenSixTen = Charachters(password);
            bool isOnlyLetterAndDigit = LetterDigit(password);
            bool isAtLeastTwoDigit = Digits(password);
            if (!isCharactersBetweenSixTen)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (!isOnlyLetterAndDigit)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (!isAtLeastTwoDigit)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
            if (isCharactersBetweenSixTen&& isOnlyLetterAndDigit&& isAtLeastTwoDigit)
            {
                Console.WriteLine("Password is valid");
            }
        }

        private static bool Digits(string password)
        {
            int coutDigit = 0;
            foreach (char ints in password)
            {
                if (char.IsDigit(ints))
                {
                    coutDigit++;
                }
            }
            return coutDigit >= 2 ? true : false;
        }

        private static bool LetterDigit(string password)
        {
            bool checker = true;
            foreach (char checkers in password)
            {
                checker = char.IsLetterOrDigit(checkers);
                if (!checker)
                {
                    return false;
                }
            }
            return checker;
        }

        private static bool Charachters(string password)
        {
            if (password.Length>=6 && password.Length<=10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

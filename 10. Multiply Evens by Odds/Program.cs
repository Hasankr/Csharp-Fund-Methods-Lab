using System;

namespace _10._Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            number = Math.Abs(number);
            int evenSum = GetSumOfEvenDigits(number);
            int oddSum = GetSumOfOddDigits(number);
            int result = GetMultipleOfEvenAndOdd(evenSum, oddSum);
            Console.WriteLine(result);
        }
        static int GetSumOfEvenDigits(int number)
        {
            int sum = 0;
            int digits = number;
            while (digits > 0)
            {
                int currDigit = digits % 10;
                if (currDigit % 2 == 0)
                {
                    sum += currDigit;
                }
                digits = digits / 10;
            }
            return sum;
        }
        static int GetSumOfOddDigits(int number)
        {
            int sum = 0;
            int digits = number;
            while (digits > 0)
            {
                int currDigit = digits % 10;
                if (currDigit % 2 != 0)
                {
                    sum += currDigit;
                }
                digits = digits / 10;
            }
            return sum;
        }
        static int GetMultipleOfEvenAndOdd(int evenSum, int oddSum)
        {
            return evenSum * oddSum;
        }
    }
}

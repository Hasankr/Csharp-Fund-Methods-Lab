using System;

namespace _08._Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double @base = double.Parse(Console.ReadLine());
            int pow = int.Parse(Console.ReadLine());
            Console.WriteLine(MathPower(@base, pow));

        }
        static double MathPower(double @base, int pow)
        {
            double result = 1;
            for (int i = 0; i < pow; i++)
            {
                 result *= @base;
            }
            return result;
        }
    }
}

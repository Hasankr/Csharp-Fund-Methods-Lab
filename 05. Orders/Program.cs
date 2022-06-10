using System;

namespace _05._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            Orders(product, quantity);
        }
        static void Orders(string product, int quantity)
        {
            double result = 0;
            if (product == "coffee")
            {
                result = 1.5 * quantity;
            }
            else if (product == "water")
            {
                result = 1 * quantity;
            }
            else if (product == "coke")
            {
                result = 1.4 * quantity;
            }
            else if (product == "snacks")
            {
                result = 2 * quantity;
            }
            Console.WriteLine($"{result:f2}");
        }
    }
}

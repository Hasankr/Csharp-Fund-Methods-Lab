using System;

namespace _09._Greater_of_Two_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            switch (type)
            {
                case "int":
                    int first = int.Parse(Console.ReadLine());
                    int second = int.Parse(Console.ReadLine());
                    Console.WriteLine(GetMax(first, second));
                    break;
                case "char":
                    char firstC = char.Parse(Console.ReadLine());
                    char secondC = char.Parse(Console.ReadLine());
                    Console.WriteLine(GetMax(firstC, secondC));
                    break;
                case "string":
                    string firstS = Console.ReadLine();
                    string secondS = Console.ReadLine();
                    Console.WriteLine(GetMax(firstS, secondS));
                    break;
            }

        }
        static int GetMax(int first, int second)
        {
            if (first > second)
            {
                return first;
            }
            
                return second;
            
        }
        static char GetMax(char first, char second)
        {
            if (first > second)
            {
                return first;
            }

            return second;

        }
        static string GetMax(string first, string second)
        {
            int result = first.CompareTo(second);
            if (result > 0)
            {
                return first;
            }
            return second;

        }
    }
}

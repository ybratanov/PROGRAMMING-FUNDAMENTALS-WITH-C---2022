using System;

namespace _1._Sign_of_Integer_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int number = int.Parse(input);
            PrintWorld(number);
            //PrintWorld(int.Parse(Console.ReadLine()));
        }

        static void PrintWorld(int number)
        {
            if (number > 0)
            {
                Console.WriteLine($"The number {number} is positive.");
            }
            else if (number < 0)
            {
                Console.WriteLine($"The number {number} is negative.");
            }
            else
            {
                Console.WriteLine($"The number {number} is zero.");
            }
        }
        
    }
}

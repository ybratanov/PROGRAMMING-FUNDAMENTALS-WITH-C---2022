using System;

namespace _09._Sum_of_Odd_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < count; i++)
            {
                int currentOddNum = 1 + (i * 2);
                Console.WriteLine(currentOddNum);
                sum += currentOddNum;
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}

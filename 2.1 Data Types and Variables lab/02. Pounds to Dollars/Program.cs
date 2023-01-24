using System;

namespace _02._Pounds_to_Dollars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pounds = int.Parse(Console.ReadLine());

            double dollers = pounds * 1.31;
            Console.WriteLine($"{dollers:f3}");
        }
    }
}

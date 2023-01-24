using System;
using System.Reflection.PortableExecutable;

namespace _09._Padawan_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());
            double priceOfSaber = double.Parse(Console.ReadLine());
            double priceOfRobes = double.Parse(Console.ReadLine());
            double priceOfBelts = double.Parse(Console.ReadLine());

            double totalNumOfSabers = Math.Ceiling(studentsCount * 1.10);
            double numbOfFreeBelts = Math.Floor(studentsCount / 6.0);

            double finalPriceForSabers = totalNumOfSabers * priceOfSaber;
            double finalPriceForRobes = studentsCount * priceOfRobes;
            double finalPriceForBelts = (studentsCount- numbOfFreeBelts) * priceOfBelts;

            double totalFinalePrice = finalPriceForSabers + finalPriceForRobes + finalPriceForBelts;

            if (budget >= totalFinalePrice)
            {
                Console.WriteLine($"The money is enough - it would cost {totalFinalePrice:f2}lv.");
            }
            else
            {
                double neededMoney = Math.Abs(totalFinalePrice - budget);
                Console.WriteLine($"John will need {neededMoney:f2}lv more.");
            }
        }
    }
}

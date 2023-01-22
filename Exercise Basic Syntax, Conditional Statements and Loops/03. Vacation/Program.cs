using System;

namespace _03._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            Friday     Saturday   Sunday

            //Students       8.45       9.80    10.46

            //Business        10.90     15.60   16

            //Regular          15       20      22.50

            int peopleCount = int.Parse(Console.ReadLine());
            string grupeType = Console.ReadLine();
            string day = Console.ReadLine();
            double totalPrice = 0;

            if (grupeType == "Students")
            {
                if (day == "Friday")
                {
                    totalPrice = peopleCount * 8.45;
                }
                else if (day == "Saturday")
                {
                    totalPrice = peopleCount * 9.80;
                }
                else if (day == "Sunday")
                {
                    totalPrice = peopleCount * 10.46;
                }
                if (peopleCount >= 30)
                {
                    totalPrice -= totalPrice * 0.15;
                }
            }
            if (grupeType == "Business")
            {
                if (day == "Friday")
                {
                    totalPrice = peopleCount * 10.90;
                }
                else if (day == "Saturday")
                {
                    totalPrice = peopleCount * 15.60;
                }
                else if (day == "Sunday")
                {
                    totalPrice = peopleCount * 16;
                }
                if (peopleCount >= 100)
                {
                    totalPrice -= totalPrice / peopleCount * 10;
                }
            }
            if (grupeType == "Regular")
            {
                if (day == "Friday")
                {
                    totalPrice = peopleCount * 15;
                }
                else if (day == "Saturday")
                {
                    totalPrice = peopleCount * 20;
                }
                else if (day == "Sunday")
                {
                    totalPrice = peopleCount * 22.50;
                }
                if (peopleCount >= 10 && peopleCount <=20)
                {
                    totalPrice -= totalPrice * 0.05;
                }
            }
            Console.WriteLine($"Total price: {totalPrice:f2}");
        }
    }
}

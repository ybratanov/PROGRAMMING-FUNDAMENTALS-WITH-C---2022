using System;

namespace _02._Sum_Digits
{
    internal class Program
    {
        static void Main(string[] args)
        {

        //First solve
            //int numInput = int.Parse(Console.ReadLine());
            //int finaleSum = 0;

            //while (numInput !=0)
            //{
            //    int lastDigit = numInput % 10;
            //    finaleSum+= lastDigit;
            //    numInput /= 10;
            //}
            //Console.WriteLine(finaleSum);

            string input = Console.ReadLine();
            int finalSum = 0;
            char[] charArray= input.ToCharArray();

            for (int value = 0; value < charArray.Length -1; value++)
            {
                finalSum += int.Parse(charArray[value].ToString());
            }
            Console.WriteLine(finalSum);
        }
    }
}

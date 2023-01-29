using System;

namespace _1._Integer_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secundNumber = int.Parse(Console.ReadLine());
            int divideNumber = int.Parse(Console.ReadLine());
            int mltyolayNumber = int.Parse(Console.ReadLine());

            //int sumNums = firstNumber + secundNumber;
            //int divisionrResult = sumNums / divideNumber;
            //int multiplayRsult = divisionrResult * divisionrResult;

            int finalRsult = (firstNumber + secundNumber) / divideNumber * mltyolayNumber;

            Console.WriteLine(finalRsult);
        }
    }
}

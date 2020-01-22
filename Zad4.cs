using System;

namespace Zad4
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            double lastNumber = -1; 
            Console.WriteLine("Calculating sum of numbers:");
            while (lastNumber != 0)
            {
                Console.WriteLine("Please give the number to sum:");
                lastNumber = Convert.ToDouble(Console.ReadLine());
                sum += lastNumber;
                Console.WriteLine("Now the sum equals: {0}", sum);
            }

        }
    }
}

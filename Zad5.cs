using System;
using System.Collections.Generic;

// lowest odd, highest even
namespace Zad5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            Console.WriteLine("Enter quantity of numbers:");
            n = Convert.ToInt32(Console.ReadLine());
            double[] numbers = new double[n];

            for(int i= 0; i < n; i++)
            {
                numbers[i] = Convert.ToDouble(Console.ReadLine());
            }

            Array.Sort(numbers);
            List<double> numbersAsList = new List<double>(numbers);
            double lowestOdd = numbersAsList.Find(number => number % 2 == 1);
            double highestEven = numbersAsList.FindLast(number => number % 2 == 0);

            Console.WriteLine("Greatest even number from a set is {0}, and lowest odd is {1}", highestEven, lowestOdd);
            Console.WriteLine("You are obligued to observe carefully, and show a joy while seeing the answer.");
        }
    }
}

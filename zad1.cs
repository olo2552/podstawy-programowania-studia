using System;
using System.Linq;

namespace Zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = Convert.ToInt32(Console.ReadLine());
            foreach (int divider in Enumerable.Range(2,9))
            {
                if (input % divider == 0)
                    Console.WriteLine("{0} is divisible by {1}", input, divider);
            }
        }
    }
}

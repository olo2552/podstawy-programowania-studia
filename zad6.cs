using System;
using System.Collections.Generic;
using System.Linq;

// lowest odd, highest even
namespace Zad5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("As haven't been specified, assuming choinka trojkatna bez dziury!");
            Console.WriteLine("Enter height of the choinka trojkatna bez dziury odrocona:");
            int christmasTreeHeight = Convert.ToInt32(Console.ReadLine());

            foreach (int currentBranchWidth in Enumerable.Range(1, christmasTreeHeight))
            {
                Console.WriteLine(new string('*', christmasTreeHeight - currentBranchWidth));
            }
        }
    }
}

using System;

//jen, bat, forint, kuna
namespace Zad2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose a currency:");
            Console.WriteLine("0 => Yen");
            Console.WriteLine("1 => Thai Baht");
            Console.WriteLine("2 => Hungarian Forint");
            Console.WriteLine("3 => Croatian Kuna");

            int selectedCurrency = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Type amount to be converted:");
            double amountToRecalculate = Convert.ToDouble(Console.ReadLine());

            // should be dict, but it's only university :P
            double[] rates = {
                0.034421, // yen
                0.1188, // baht
                0.013491, // forint
                0.5780 // kuna
            };

            double result = amountToRecalculate * rates[selectedCurrency];

            Console.WriteLine("In PLN it will be {0}zl", Math.Round(result, 4));
        }
    }
}

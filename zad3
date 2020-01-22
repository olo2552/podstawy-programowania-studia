using System;

//jen, bat, forint, kuna
namespace Zad2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculating part of the circle:");
            Console.WriteLine("Please give the radius of a circle:");

            double radius = -1;
            double angle = -1;
            bool hasStupidMistake = false;

            do
            {
                //guarding twoja_stara input value
                try
                {
                    radius = Convert.ToDouble(Console.ReadLine());
                }
                catch (FormatException notANumberStringError)
                {
                    Console.WriteLine("Radius should be a valid number");
                    hasStupidMistake = true;
                    continue;
                }

                if (radius < 0)
                {
                    hasStupidMistake = true;
                    Console.WriteLine("Radius has to be positive, please enter valid radius");
                    continue;
                }

                //everything is fine
                hasStupidMistake = false;
            } while (hasStupidMistake);

            Console.WriteLine("Radius: {0}", radius);
            Console.WriteLine("Please enter angle in degrees between 0 and 360", angle);
            do
            {
                //guarding twoja_stara input value
                try
                {
                    angle = Convert.ToDouble(Console.ReadLine());
                }
                catch (FormatException notANumberStringError)
                {
                    Console.WriteLine("Angle should be a valid number");
                    hasStupidMistake = true;
                    continue;
                }

                if (angle < 0)
                {
                    hasStupidMistake = true;
                    Console.WriteLine("Radius has to be positive, please enter valid radius");
                    continue;
                }
                if (angle > 360)
                {
                    hasStupidMistake = true;
                    Console.WriteLine("Radius has to be less than 360*");
                    continue;
                }
                //everything is fine
                hasStupidMistake = false;
            } while (hasStupidMistake);
            
            Console.WriteLine("Angle: {0}", angle);

            double result = (angle / 360) * Math.PI * (radius * radius);
            Console.WriteLine("Field of the part of the circle is: {0}", result);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace TabliceMatematyczne
{
    class Program
    {
        // Zapytać coacha: jak te dwie metody przeciążyć generycznie ze względu na typ?
        static private int getAndValidateNonNegativeInt32()
        {
            bool hasStupidMistake = false;
            int value = -1;
            do
            {
                //guarding twoja_stara input value
                try
                {
                    value = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException notANumberStringError)
                {
                    Console.WriteLine("Value should be a valid number");
                    hasStupidMistake = true;
                    continue;
                }
                
                if (value <= 0)
                {
                    hasStupidMistake = true;
                    Console.WriteLine("Value has to be positive, please enter valid radius");
                    continue;
                }
                
                //everything is fine
                hasStupidMistake = false;
            } while (hasStupidMistake);

            return value;
        }

        static private double getAndValidateNonNegativeDouble()
        {
            bool hasStupidMistake = false;
            double value = -1;
            do
            {
                //guarding twoja_stara input value
                try
                {
                    value = Convert.ToDouble(Console.ReadLine());
                }
                catch (FormatException notANumberStringError)
                {
                    Console.WriteLine("Value should be a valid number");
                    hasStupidMistake = true;
                    continue;
                }

                if (value < 0)
                {
                    hasStupidMistake = true;
                    Console.WriteLine("Value has to be positive, please enter valid radius");
                    continue;
                }

                //everything is fine
                hasStupidMistake = false;
            } while (hasStupidMistake);

            return value;
        }
        static private void handleFactorialSection()
        {
            Console.WriteLine("Enter number to calculate facotrial:");
            int n = getAndValidateNonNegativeInt32();

            Console.WriteLine("The factorial of {0} is {1}", n, factorial(n));
        }

        static private int factorial(int n)
        {
            if (n == 0) return 1;
            return n * factorial(n - 1);
        }
        static private void handleCompoundInterest()
        {
            Console.WriteLine("Compound interest of a deposit can easily tell you what your profit will be after amount of years for particular capital.");
            Console.WriteLine("Enter initial capital:");
            double initialCapital = getAndValidateNonNegativeDouble();
            
            Console.WriteLine("Enter number of years:");
            int numberOfYears = getAndValidateNonNegativeInt32();

            Console.WriteLine("Enter rate percentage:");
            double rate = getAndValidateNonNegativeDouble();


            Console.WriteLine("For given values, profit will be: {0}", compoundInterest(initialCapital, numberOfYears, rate));
        }
        static private double compoundInterest (double initialCapital, int numberOfYears, double rate)
        {
            double valueWithGainAfterAYear = 1 + (rate / 100);
            return initialCapital * Math.Pow(valueWithGainAfterAYear, numberOfYears);
        }
        static private void handleCircleField()
        {
            Console.WriteLine("Enter radius of a circle:");
            double radius = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Field of this circle is: {0}", circleField(radius));
        }
        static private double circleField(double r)
        {
            return Math.PI * r * r;
        }
        static private void handleQuboidVolume()
        {
            Console.WriteLine("Enter base height:");
            double baseHeight = getAndValidateNonNegativeDouble();
            
            Console.WriteLine("Enter base width:");
            double baseWidth = getAndValidateNonNegativeDouble();

            Console.WriteLine("Enter qubiod height:");
            double quboidHeight= getAndValidateNonNegativeDouble();

            Console.WriteLine("THe volume of the quboid, of the given dimentions is: {0}", quboidVolume(baseHeight, baseWidth, quboidHeight));
        }
        static private double quboidVolume(double baseHeight, double baseWidth, double height)
        {
            return height * baseHeight * baseWidth;
        }

        static private void handleSinus()
        {
            Console.WriteLine("Enter an angle:");
            double angle = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Math.Sin(angle));
        }
        static private int chooseAmongPossibleFunctions()
        {
            Console.WriteLine("");
            Console.WriteLine("You have TONS of options to choose my friend:");

            Console.WriteLine("Enter 1 to calculate factorial of a number");
            Console.WriteLine("Enter 2 to calculate compound interest");
            Console.WriteLine("Enter 3 to calculate field of a circle");
            Console.WriteLine("Enter 4 to calculate volume of a quboid");
            Console.WriteLine("Enter 5 to calculate value of a sinus of particular angle");

            Console.WriteLine("Press 0 to quit");

            return Convert.ToInt32(Console.ReadLine());
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Created by Haxx0r, know as Aleksander Wielgorski, HBS index no. 51266 ");
            int currentlySelectedFuntion = -1;

            while(currentlySelectedFuntion != 0)
            {
                currentlySelectedFuntion = chooseAmongPossibleFunctions();

                if (currentlySelectedFuntion == 1)
                {
                    handleFactorialSection();
                }

                if (currentlySelectedFuntion == 2)
                {
                    handleCompoundInterest();
                }

                if (currentlySelectedFuntion == 3)
                {
                    handleCircleField();
                }

                if (currentlySelectedFuntion == 4)
                {
                    handleQuboidVolume();
                }

                if (currentlySelectedFuntion == 5)
                {
                    handleSinus();
                }
            }
            // Pozdro dla tych, co do końca kod sprawdzają
            // walidacja ssie pałkę, ale uznałem, że mam inne rzeczy do roboty, niż nurkować w ścieku po łokcie
            // produkcyjnie  tak użyłbym class-transformera, Joi albo innego schema-based validatora
            // https://github.com/typestack/class-validator
            // https://github.com/hapijs/joi
        }
    }
}

using System;

namespace More_on_Numeric_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many miles have you driven?");
            double milesDriven = double.Parse(Console.ReadLine());

            Console.WriteLine("How many gallons of gas have you consumed?");
            double gasConsumed = double.Parse(Console.ReadLine());

            string mpg = (milesDriven / gasConsumed).ToString();
            Console.WriteLine("You are getting " + mpg + " miles to the gallon.");

        }
    }
}

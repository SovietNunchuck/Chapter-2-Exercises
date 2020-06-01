using System;

namespace Numeric_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the length of the rectangle?");
            double rectangleLength = double.Parse(Console.ReadLine());

            Console.WriteLine("What is the width of the rectangle?");
            double rectangleWidth = double.Parse(Console.ReadLine());

            string areaOfRectangle = (rectangleLength * rectangleWidth).ToString();
            Console.WriteLine("The area of the rectangle is " + areaOfRectangle);
        }
    }
}

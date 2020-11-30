using System;

namespace More_Numeric_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many miles have you traveled?");
            string input1 = Console.ReadLine();
            Console.WriteLine("How many gallons have you used?");
            string input2 = Console.ReadLine();
            double miles = double.Parse(input1);
            double gallons = double.Parse(input2);
            double mpg = miles / gallons;
            Console.WriteLine("You are getting " + mpg + " miles per gallon of fuel.");
        }
    }
}

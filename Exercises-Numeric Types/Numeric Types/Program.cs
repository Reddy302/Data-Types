using System;

namespace Numeric_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the length of the rectangle?");
            string length = Console.ReadLine();
            Console.WriteLine("What is the width of the rectangle?");
            string width = Console.ReadLine();
            int intLength = int.Parse(length);
            int intWidth = int.Parse(width);
            int area = intLength * intWidth;
            Console.WriteLine("The area of the rectangle is " + area);
        }
    }
}

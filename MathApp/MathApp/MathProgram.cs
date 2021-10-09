using System;

namespace MathApp
{
    class MathProgram
    {
        static void Main(string[] args)
        {
            int highestValue = Math.Max(13, 12);
            int lowestValue = Math.Min(44, 22);
            double squareRoot = Math.Sqrt(25);
            double roundedNumber = Math.Round(24.5);
            double absoluteValue = Math.Abs(-5);
            
            Console.WriteLine($"The highest number between 13 and 12 is: {highestValue}");
            Console.WriteLine($"The lowest number between 44 and 2 is: {lowestValue}");
            Console.WriteLine($"The square root of 25 is: {squareRoot}");
            Console.WriteLine($"The rounded value of 24.5 is: {roundedNumber}");
            Console.WriteLine($"The absolute value of -5 is: {absoluteValue}");
        }
    }
}
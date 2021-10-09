using System;
using System.Linq;

namespace ComputerAverageApp
{
    class ComputeAverageProgram
    {
        static void Main(string[] args)
        {
            int inputs = 0;
            bool isLoopStarted = false;
            double[] grades = new double[5];
            
            while (inputs != 5)
            {
                if (!isLoopStarted)
                {
                    Console.WriteLine("Enter 5 grades seperated by new line:");
                    isLoopStarted = true;
                }

                try
                {
                    double input = Convert.ToDouble(Console.ReadLine());
                    grades[inputs] = input;
                    inputs++;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter a valid grade input.");
                }
            }

            double average = Math.Round(grades.Sum() / 5, 2);
            Console.WriteLine($"The average is {average} and round off to {Math.Round(average)}");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<double> numbers = new List<double>();

        Console.WriteLine("Enter 10 numbers:");

        // Read 10 numbers from the user
        for (int i = 0; i < 10; i++)
        {
            Console.Write("Enter number {0}: ", i + 1);
            double number = Convert.ToDouble(Console.ReadLine());
            numbers.Add(number);
        }

        // Calculate minimum, maximum, and average
        double min = numbers.Min();
        double max = numbers.Max();
        double avg = numbers.Average();

        // Display the results
        Console.WriteLine("\nMinimum: " + min);
        Console.WriteLine("Maximum: " + max);
        Console.WriteLine("Average: " + avg);
    }
}

using System;
using System.Collections.Generic;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        // Message
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        // Create an empty list
        List<int> numbers = new List<int>();

        while (true)
        {

            // Initialize the questions
            Console.Write("Enter number: ");
            int userInput = int.Parse(Console.ReadLine());

            if (userInput == 0)
            {
                break;
            }

            numbers.Add(userInput);
        }

        int sum = 0;
        int max = int.MinValue;
        int min = int.MaxValue;


        foreach (int num in numbers)
        {
            if (num > max)
            {
                max = num;
            }

            if (num < min)
            {
                min = num;
            }

            sum += num;

        }

        double average = sum / numbers.Count;

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The maximum value is: {max}");
        Console.WriteLine($"The minimum value is: {min}");
        Console.WriteLine("The sorted list is:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}
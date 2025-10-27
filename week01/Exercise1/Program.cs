using System;

class Program
{
    static void Main(string[] args)
    {   

        // Create Input for the user
        Console.Write("What is your first name? ");
        string first_name = Console.ReadLine();
        Console.Write("What is your last name? ");
        string last_name = Console.ReadLine();

        // Example of how Sting Interpolation is used
        Console.Write($"Your name is {first_name}, {first_name} {last_name}.");
    }
}
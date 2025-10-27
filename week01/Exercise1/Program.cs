using System;

class Program
{
    static void Main(string[] args)
    {   

        // Create Input for the user
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();
        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();

        // Example of how Sting Interpolation is used
        Console.Write($"Your name is {firstName}, {firstName} {lastName}.");
    }
}
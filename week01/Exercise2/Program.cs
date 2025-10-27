using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your grade: ");
        string valueFromUser = Console.ReadLine();
        int integerValue = int.Parse(valueFromUser);

        string letter = "";
        string signedValue = "";

        int lastDigit = integerValue % 10;

        // If remained digits = 7 or 3
        if (lastDigit >= 7)
        {
            signedValue = "+";
        }
        else if (lastDigit <= 3)
        {
            signedValue = "-";
        }

        if (integerValue >= 90)
        {
            letter = "A";
        }
        else if (integerValue >= 80)
        {
            letter = "B";
        }
        else if (integerValue >= 70)
        {
            letter = "C";
        }
        else if (integerValue >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Signed values
        if (letter == "A" && signedValue == "+")
        {
            signedValue = "";
        }

        if (letter == "F" && (signedValue == "+" || signedValue == "-"))
        {
            signedValue = "";
        }

        Console.WriteLine($"You have a grade {letter}{signedValue}.");

        if (integerValue >= 70)
        {
            Console.WriteLine($"Congratulations! You passed the course with a {letter}");
        }
        else
        {
            Console.WriteLine($" The grade is {letter}. Don't give up — you'll do better next time!");
        }
    }
}

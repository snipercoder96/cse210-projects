using System;

class Program
{
    static void Main(string[] args)
    {
        // Using the no-parameter constructor → 1/1
        Fraction f1 = new Fraction();
        Console.WriteLine(f1.GetFractionString());   // Output: 1/1
        Console.WriteLine(f1.GetDecimalValue());     // Output: 1

        // Using the one-parameter constructor → 6/1
        Fraction f2 = new Fraction(6);
        Console.WriteLine(f2.GetFractionString());   // Output: 6/1
        Console.WriteLine(f2.GetDecimalValue());     // Output: 6

        // Using the two-parameter constructor → 6/7
        Fraction f3 = new Fraction(6, 7);
        Console.WriteLine(f3.GetFractionString());   // Output: 6/7
        Console.WriteLine(f3.GetDecimalValue());     // Output: 0.857142857...
    
    }
}
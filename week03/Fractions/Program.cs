using System;

class Program
{
    static void Main(string[] args)
    {
        // No parameters
        Fraction f1 = new Fraction();
        Console.WriteLine(f1.GetFractionString());  
        Console.WriteLine(f1.GetDecimalValue());     

        // One parameter
        Fraction f2 = new Fraction(6);
        Console.WriteLine(f2.GetFractionString());   
        Console.WriteLine(f2.GetDecimalValue());     

        // Two parameters
        Fraction f3 = new Fraction(6, 7);
        Console.WriteLine(f3.GetFractionString());   
        Console.WriteLine(f3.GetDecimalValue());     



    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        //Testing procedure
        Reference book1 = new Reference("John", 3, 16, 18);
        Console.WriteLine(book1.GetDisplayText());
    
    }
}
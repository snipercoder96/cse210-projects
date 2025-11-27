using System;

class Program
{
    static void Main(string[] args)
    {
        // TEsting procedure

        Assignment assignment = new Assignment("Samuel Bennett", "Multiplication");
        MathAssignment math = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        WritingAssignment writing = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");

        List<string> animationBack = new List<string>
        {
            "|", "/", "-", "\\", "|", "/", "-", "\\", "|"
        };

        Console.Write("Please wait ");
        Thread.Sleep(2000);

        foreach (string animations in animationBack)
        {
            Console.Write(animations);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.Clear();
        Console.WriteLine("\nIts Ready\n");
        Console.WriteLine(assignment.GetSummary());
        Console.WriteLine(math.GetSummary());
        Console.WriteLine(math.GetHomeworkList());
        Console.WriteLine(writing.GetSummary());
        Console.WriteLine(writing.GetWritingInformation());

        DateTime startTime = DateTime.Now;
        Console.WriteLine(startTime);
        // animations 


        // Testing Procedure



        // Testing procedure



    }
}
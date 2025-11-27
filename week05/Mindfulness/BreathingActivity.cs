/*Breathing activity will inherit activity */
using System.Linq.Expressions;

class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description, int duration) : base(name, description, duration)
    {

    }

    public void Run()
    {
        Console.WriteLine("Welcome to the breathing activity\n");
        Console.WriteLine(GetDescription());

        // Set in a variable
        int response = AskUserForDuration();
        SetDuration(response); // Sets duration to response
        Console.Clear();
        

        Console.WriteLine("Get ready...");
        ShowSpinner(GetDuration());
        Console.WriteLine();
        int cycleTime = 3; // Seconds
        int totalDuration = GetDuration(); // eg 10
        int cycles = totalDuration / cycleTime; // 10 / 3 → 3 steps(int)

        for (int i = 0; i < cycles; i++)
        {
            Console.Write("Breathe in...");
            ShowCountDown(4);
            Console.Write("\nBreathe out...");
            ShowCountDown(4);
            Console.WriteLine();
            Console.WriteLine();
        }

        DisplayEndingMessage();
        
    }
}
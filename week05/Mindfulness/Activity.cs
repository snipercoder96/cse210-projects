/* Easiest class to work with → Parent class*/


class Activity
{
    private string _name; // Name of Activity
    private string _description;
    private int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public string GetName() // get name
    {
        return _name;
    }

    public int GetDuration() // get duration
    {
        return _duration;
    }

    public void SetDescription(string description) // set description
    {
        _description = description;
    }

    public void SetDuration(int duration) // set duration
    {
        _duration = duration;
    }

    public string GetDescription() // get description
    {
        return _description;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine("Menu options:\n");
        Console.WriteLine("1. Start breathing activity");
        Console.WriteLine("2. Start reflecting activity");
        Console.WriteLine("3. Start listing activity");
        Console.WriteLine("4. Quit");
        // Use console.Clear() in the main program after the user question
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nWell done!!\n");
        if (GetDuration() > 0)
        {
            Console.WriteLine($"You have completed {GetDuration()} seconds of the {GetName()} activity");
        }
        else
        {
            Console.WriteLine($"You have completed the {GetName()} activity");
        }
    }

    public void ShowSpinner(int seconds)
    {
        List<string> spinnerAnimation = new List<string>
        {
            "|", "/", "-", "\\", "|"
        };

        DateTime endTime = DateTime.Now.AddSeconds(seconds);
        int i = 0;

        while (DateTime.Now < endTime) // Does two jobs at once, checking time and iterating the spinner
        {
            Console.Write(spinnerAnimation[i % spinnerAnimation.Count]); // normally → spinnerAnimation[i] but, modulus returns remainder
            Thread.Sleep(200); // 200ms per frame
            Console.Write("\b \b");
            i++;
        }
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public int AskUserForDuration()
    {
        Console.Write("\nHow long in seconds, would you like your session? ");
        int response = int.Parse(Console.ReadLine());
        return response;
    }

    public string ReflectingResponse()
    {
        Console.Write("\nWhen you have something in mind, press enter to continue ");
        string response = Console.ReadLine();
        return response;
    }

}
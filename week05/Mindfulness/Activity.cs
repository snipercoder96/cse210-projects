/* Easiest class to work with → Parent class*/
using System.IO;
using System.Text.Json;


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
        Console.WriteLine("4. Save activity");
        Console.WriteLine("5. Load Activity");
        Console.WriteLine("6. Quit");
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

    /*
    For saving and loading:

    SAVING:
    - Activity class → Whatever activity the user saved
    (IN the main program ask question on what user wants to save as)
    (Add an extra of 2 options in the menu)
    eg → DateActivity was done → Name of activity → Description of the activity → Duration of an activity
    LOADING:
    Ask the user for the name of the file → If present, load else → Error, file not found. */

    public void SaveActivity(string filename, List<Activity> activities)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {

            foreach (Activity activity1 in activities)
            {
                writer.WriteLine(activity1.GetName());
                writer.WriteLine(activity1.GetDescription());
                writer.WriteLine(activity1.GetDuration());
                writer.WriteLine();
            }
        }
    }

    public void LoadFromFile(string filename, List<Activity> activities)
    {
        if (File.Exists(filename))
        {
            activities.Clear();

            using (StreamReader reader = new StreamReader(filename))
            {
                while (!reader.EndOfStream) // If it isn't null or
                {
                    // Read properties in the same order they were saved
                    string name = reader.ReadLine();
                    string description = reader.ReadLine();
                    string durationLine = reader.ReadLine();
                    reader.ReadLine(); // read the blank separator line

                    // Convert duration back to int
                    int duration = int.Parse(durationLine);

                    Activity loadedActivity = new Activity(name, description, duration);

                    // Add to the list
                    activities.Add(loadedActivity);
                }
            }
            ShowSpinner(5);
            Console.WriteLine("Activities loaded successfully!");
        }
        else
        {
            ShowSpinner(6);
            Console.WriteLine("Error: File not found.");
        }
    }
}


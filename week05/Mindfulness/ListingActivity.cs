/*Inherit from Activity class*/
class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>();
    public ListingActivity(string name, string description, int duration) : base(name, description, duration)
    {
        _count = 0;
    }

    public void Run()
    {
        Console.WriteLine("Welcome to the Listing Activity.");
        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.\n");

        
        int duration = AskUserForDuration();
        SetDuration(duration);
        Console.Clear();

        Console.WriteLine("Get ready...");
        ShowSpinner(3);
        Console.WriteLine("List as many responses as you can to the following prompt:\n");
        GetRandomPrompt();
        
        Console.WriteLine();

        List<string> responses = GetListFromUser();
        Console.WriteLine($"\nYou listed {responses.Count} items!");
        DisplayEndingMessage();
    }

    public void GetRandomPrompt()
    {

        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };

        Random randomPrompt = new Random();
        int i = randomPrompt.Next(_prompts.Count);
        string selectedPrompt = _prompts[i];

        Console.WriteLine($"---{selectedPrompt}---");
    }

    public List<string> GetListFromUser()
    {
        List<string> responses = new List<string>();

        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime) // Time from user question
        {
            string response = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(response))
            {
                responses.Add(response);
            }
        }

        _count = responses.Count;
        return responses;
    }

    public int GetCount()
    {
        return _count;
    }

    public void SetCount(int count)
    {
        _count = count;
    }
}
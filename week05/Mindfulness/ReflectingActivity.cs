

class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity(string name, string description, int duration, List<string> prompts, List<string> questions) : base(name, description, duration)
    {
        _prompts = prompts;
        _questions = questions;
    }

    public void Run()
    {
        Console.WriteLine("Welcome to the Reflecting Activity.\n");
        Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.\n");

        int response1 = AskUserForDuration();
        SetDuration(response1);
        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(3);
        Console.WriteLine("Consider the following prompt:\n");
        DisplayPrompt();
        Console.WriteLine();


        string response = ReflectingResponse();

        if (string.IsNullOrWhiteSpace(response))
        {
            Console.WriteLine("Now you may ponder on each of the following questions as they related to this experience");
            Console.Write("You may begin in: ");
            ShowCountDown(5);
            Console.Clear();
        }
        DisplayQuestions();
        DisplayEndingMessage();
        
    }

    public string GetRandomPrompt()
    {
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };
        Random randomPrompt = new Random();
        int i = randomPrompt.Next(_prompts.Count);
        string selectedPrompt = _prompts[i];
        return $"---{selectedPrompt}---";
    }

    public void GetRandomQuestion()
    {
        _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());
        int i = 0;

        while (DateTime.Now < endTime)
        {
            string randomQuestion = _questions[i % _questions.Count];
            Console.WriteLine(randomQuestion);

            ShowSpinner(5);
            i++;
        }
    }

    public void DisplayPrompt()
    {
        Console.WriteLine(GetRandomPrompt());
    }

    public void DisplayQuestions()
    {
        foreach (string question in _questions)
        {
        
            Console.Write($"\n{question} ");
            ShowSpinner(5);
        }
    }

}
/// Display text randomly
/// 

using System;
using System.Collections.Generic;


class DisplayPromptText
{
    List<string> _prompts;


    public DisplayPromptText()
    {
        _prompts = new List<string>
        {
            "What do you plan to do today?",
            "What is one thing you have learned today?",
            "What is the thing you want to achieve today?",
            "What are you most grateful for today?",
            "Who was your inspiration today?",
            "What could you do to improve for the future?",

        };
            
        
    }
    public Entry GetEntry()
    {
        Random randText = new Random();
        int indexNum = randText.Next(_prompts.Count);
        string prompt = _prompts[indexNum];

        Console.WriteLine(prompt);
        Console.WriteLine("What is your response:\n");
        string response = Console.ReadLine();

        Console.Write("What is your mood today? ");
        string mood = Console.ReadLine();

        string date = DateTime.Now.ToString("yyyy-MM-dd");

        return new Entry(date, mood, prompt, response);
    }
}
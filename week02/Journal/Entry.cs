//Write a new entry
using System;
using System.Collections.Generic;

/*
Exceeding Requirements:

-Added Mood but under the get property
*/
class Entry
{
    // Reason for private is to avoid interference with changes
    private string _date;
    private string _promptText;
    private string _entryText;

    /* Added Mood for Exceeding requirements */
    public string _mood { get; }

    public Entry(string date, string mood, string promptText, string entryText)
    {
        _date = date;
        _mood = mood;
        _promptText = promptText;
        _entryText = entryText;

    }

    public void Display(bool showMood = false)
    {
        if (showMood == true)
        {
            Console.WriteLine($"Date: {_date} \nMood: {_mood} \nPrompt: {_promptText} \nResponse: {_entryText}\n");
        }
        else
        {
            Console.WriteLine($"Date: {_date} \nPrompt: {_promptText} \nResponse: {_entryText}\n");
        }
    }

    // .WritLine expects a string, not a void 
    public string ToFormattedString()
    {
        return $"{_date}|{_mood}|{_promptText}|{_entryText}";
    }

}


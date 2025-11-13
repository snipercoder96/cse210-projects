using System;
using System.Collections.Generic;

/*
- Exceeding requirements: Custom number of words to hide Let the user type how many words they want 
hidden each round (instead of always 3 ). That’s a one‑line change in your loop.

Exceeding requirements is shown with --
*/

class Program
{
    static void Main(string[] args)
    {
        // Display scriptures
        Reference r1 = new Reference("John", 3, 16);
        string verseRef = "For God So loved the world that he gave his one and only son that whoever believes in him should not perish but have eternal life";
        Scripture s1 = new Scripture(r1, verseRef);
        Word w1 = new Word(verseRef);

        Console.WriteLine($"{s1.GetDisplayText()}");

        // ------------------------------------------------------------------------------------
        // Added Custom number of words for exceeding requirements to what the user wants.
        Console.WriteLine("\nHow many words do you want hidden? ");
        int hiddenWords = int.Parse(Console.ReadLine());
        // ------------------------------------------------------------------------------------

        while (true)
        {
            Console.Write("\nPress Enter to continue or type 'q' or 'quit' to finish ");
            string response = Console.ReadLine().ToLower();

            if (response == " " || response == "")
            {
                s1.HideRandomWords(hiddenWords);
                Console.Clear();
                Console.WriteLine(s1.GetDisplayText());

                if (s1.IsCompletelyHidden())
                {
                    break;
                }
            }
            else if (response == "quit" || response == "q")
            {
                break;
            }
        }


    }
}
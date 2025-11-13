using System;
using System.IO;

/* Exceeding requirements: Added mood in Entry, Journal class
*/



class JournalProgram
{
    static void Main(string[] args)


    {

        Journal journal = new Journal();
        int choice = 0;

        while (choice != 5)
        {


            DisplayMenu();
            int user = UserEntry();

            if (user == 1)
            {
                DisplayPromptText randomizedText = new DisplayPromptText();
                Entry response = randomizedText.GetEntry();
                journal.AddEntry(response);

            }

            else if (user == 2)
            {   
                // Added Mood for exceeding requirements.
                journal.DisplayAllEntries();
            }

            else if (user == 3)
            {   
                
                Console.Write("What file would you like to save it as? ");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename);
                Console.WriteLine("Saving...");
                Console.WriteLine("Saved successfully!");


            }
            else if (user == 4)
            {

                Console.WriteLine("What is the name of the file? ");
                Console.WriteLine("Retrieving file....");
                string readingFile = Console.ReadLine();
                journal.LoadFromFile(readingFile);
            }
            if (user == 5)
            {
                Console.WriteLine("Goodbye!");
                break;
            }


        }

    }

    static void DisplayMenu()
    {
        Console.WriteLine("\nWelcome to the Journal App");
        Console.WriteLine("1. Write a new entry");
        Console.WriteLine("2. Display all entries");
        Console.WriteLine("3. Save journal to file");
        Console.WriteLine("4. Load journal from file");
        Console.WriteLine("5. Quit\n");
    }

    static int UserEntry()
    {
        Console.Write("What would you like to do? ");
        int user = int.Parse(Console.ReadLine());
        return user;
    }
}
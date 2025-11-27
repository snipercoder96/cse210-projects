using System;

class Program
{
    static void Main(string[] args)
    {
        // Testing procedure
        bool running = true; // Important, especially for case 4

        while (running)
        {
            // Show menu from Activity base class
            Activity menu = new Activity("Menu", "Main menu", 0);
            menu.DisplayStartingMessage();

            Console.Write("\nSelect a choice from the menu: ");
            int choice = int.Parse(Console.ReadLine());
            Console.Clear();

            // Learnt switch cases for Clean code

            switch (choice)
            {
                case 1:

                    BreathingActivity breathing = new BreathingActivity("Breathing",
                    "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.", 0);
                    breathing.Run();
                    break;

                case 2:
                    ReflectingActivity reflecting = new ReflectingActivity(
                        "Reflecting",
                        "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.",
                        0,
                        new List<string>(), // prompts 
                        new List<string>
                        {
                            "Why was this experience meaningful to you?",
                            "Have you ever done anything like this before?"
                        }  // questions
                    );
                    reflecting.Run();
                    break;

                case 3:
                    ListingActivity listing = new ListingActivity(
                        "Listing",
                        "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.",
                        0
                    );
                    listing.Run();
                    break;

                case 4:
                    Console.WriteLine("Goodbye!");
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please choose carefully.");
                    break;
            }

            Console.WriteLine("\nPress Enter to return to the menu...");
            Console.ReadLine();
            Console.Clear();
        }

    }
}
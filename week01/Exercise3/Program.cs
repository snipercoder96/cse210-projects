using System;

class Program
{
    static void Main(string[] args)
    {
        // initialize a score
        int winScore = 0;
        int lossScore = 0;


        // Loop as long as it is true and tries = 3
        while (true)

        {
            // Initialize tries
            int tries = 3;
            
            // Create a computer guess
            Random randomGenerator = new Random();
            int computerGuess = randomGenerator.Next(1, 101);

            while (tries > 0)

            {
                // Ask for the magic number
                Console.Write("What is the magic number? ");
                int userGuess = int.Parse(Console.ReadLine());


                // Create comparison between guess and computer
                if (userGuess > computerGuess)
                {
                    Console.WriteLine("Too high");
                    tries -= 1;
                    continue;
                }

                else if (userGuess < computerGuess)
                {
                    Console.WriteLine("Too low");
                    tries -= 1;
                    continue;
                }
                else
                {
                    Console.WriteLine($"Congratulations, you guessed it correctly.\nThe number was {computerGuess}. Your score is {winScore} win(s)");
                    winScore += 1;
                    break;
                }

            }
            if (tries == 0)
            {
                lossScore += 1;
                Console.WriteLine($"Game over! The answer is {computerGuess}.\nYour score is {lossScore} losse(s).");

            }
        
            // Create a replay again
            Console.Write("Would you like to play again (yes/ no)");
            string response = Console.ReadLine().ToLower();

            if (response != "yes" && response != "y")
            {
                Console.WriteLine("Have a great day.");
                break;
            }

            
            
        }
    }
}
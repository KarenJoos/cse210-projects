using System;
using System.Net.Http.Headers;

Random random = new Random();
bool retry = true;
do
{
    int number = random.Next(1, 100);

    while (true)
    {
        Console.Write("I am thinking of a number between 1-100. Can you guess what? ");
        string input = Console.ReadLine();
        int guess = Convert.ToInt32(input);

        if (guess > number)
        {
            Console.WriteLine("Lower");
        }

        else if (guess < number)
        {
            Console.WriteLine("Higher");
        }

        else
        {
            Console.WriteLine("You guessed it!");
            Console.WriteLine("Would you like to play again? y/n");
            string answer = Console.ReadLine();
            if (answer != "y")
            {
                retry = false;
                Console.WriteLine("Thanks for playing.");
            }
            break;
        }
    }
} while (retry);

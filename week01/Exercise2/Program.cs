using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string answer = Console.ReadLine();
        int percent = int.Parse(answer);

        string letter = "";


        if (percent >= 90)
        {
            letter = "A";
        }

        else if (percent < 90 && percent >= 80)
        {
            letter = "B";
        }

        else if (percent < 80 && percent >= 70)
        {
            letter = "C";
        }

        else if (percent < 70 && percent >= 60)
        {
            letter = "D";
        }

        else
        {
            letter = "F";
        }

        Console.WriteLine($"You got a {letter}.");

        if (percent >= 70)
        {
            Console.WriteLine("You passed!");
        }

        else
        {
            Console.WriteLine("Better luck next time.");
        }
    }
}
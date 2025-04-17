using System;
using System.Reflection.Metadata;

public class ListingActivity : Activity
{
    private int _count;

    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity(string name, string description, int duration) : base(name, description, duration)
    {

    }

    public void Run()
    {
        DisplayStartingMessage();
        int duration = GetDuration();
        Console.WriteLine("Get ready to list your thoughts.");
        ShowSpinner(3);
        GetRandomPrompt();
        ShowCountDown(5);
        Console.WriteLine($"List as many items as you can in {duration} seconds.\n");
        DateTime startTime = DateTime.Now;
        int _count = 0;
        while ((DateTime.Now - startTime).TotalSeconds < duration)
        {
            Console.WriteLine($">");
            string userInput = Console.ReadLine();

            if (!string.IsNullOrEmpty(userInput))
            {
                _count++;
            }
        }

        Console.WriteLine($"\nTime's up! You listed {_count} items");

        ShowSpinner(3);

        DisplayEndingMessage();
    }

    public void GetRandomPrompt()
    {
        Random random = new Random();
        int randomPromptIndex = random.Next(_prompts.Count);
        string prompt = _prompts[randomPromptIndex];
        Console.WriteLine($"\n--- Prompt ---\n{prompt}\n");
    }

    public List<string> GetListFromUser()
    {
        
    }
}
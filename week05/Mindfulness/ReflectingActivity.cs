using System;
using System.Runtime.CompilerServices;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>
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

    public ReflectingActivity(string name, string description, int duration) : base(name, description, duration)
    {

    }

    public void Run()
    {
        DisplayStartingMessage();
        int duration = GetDuration();
        Console.WriteLine("Get ready to reflect on a prompt.");
        ShowSpinner(3);
        Random random = new Random();
        int randomPromptIndex = random.Next(_prompts.Count);
        string prompt = _prompts[randomPromptIndex];
        Console.WriteLine("When you are ready press enter to continue\n");
        Console.ReadLine();
        ShowSpinner(3);
        Console.WriteLine("Now ponder on each of the folowing questions as they relate to this experience.\n");

        int questionDuration = 10;
        int maxQuestions = duration / questionDuration;

        for (int i = 0; i < maxQuestions; i++)
        {
            Console.WriteLine(_questions[i]);
            ShowSpinner(questionDuration);
            duration -= questionDuration;
            Console.WriteLine();
        }

        ShowSpinner(3);

        DisplayEndingMessage();

    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int randomIndex = random.Next(_prompts.Count);
        return _prompts[randomIndex];
    }

    public string GetRandomQuestion()
    {
        Random random = new Random();
        int randomIndex = random.Next(_questions.Count);
        return _questions[randomIndex];
    }

    public void DisplayPrompt()
    {
        Console.WriteLine($"Question: {GetRandomPrompt()}");
    }

    public void DisplayQuestions()
    {
        Console.WriteLine($"Question: {GetRandomQuestion()}");
    }
}
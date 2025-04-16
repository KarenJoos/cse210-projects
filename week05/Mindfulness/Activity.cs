using System;

public class Activity
{
    private string _name;
    private string _description;

    private int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}.\n");
        Console.WriteLine($"{_description}\n");
        Console.Write("How long, in seconds, would you like for your session? ");
        int duration = int.Parse(Console.ReadLine());
        _duration = duration;

        ShowSpinner(3);

    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("Congratulations!\n");
        Console.WriteLine($"You have completed another {_duration} of the {_name}\n");
        Thread.Sleep(5000);
        ShowSpinner(3);
    }

    public void ShowSpinner(int seconds)
    {
        Console.Write("+");

        Thread.Sleep(5000);

        Console.Write("\b \b");
        Console.Write
    }

    public void ShowCountDown(int seconds)
    {

    }

    public
}
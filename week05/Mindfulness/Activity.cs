using System;


public class Activity
{
    private string _name;
    private string _description;
    private int _duration;
    private static int _count;
    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void DisplayStartingMessage()
    {
        _count++;
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
        Thread.Sleep(5000);
        Console.WriteLine($"You have completed another {_duration} of the {_name}\n");
        Console.WriteLine($"\nTotal number of activities done so far{_count}");
        ShowSpinner(3);
        Menu menu = new Menu();
        menu.MenuActivities();
    }

    public void ShowSpinner(int seconds)
    {
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        string[] spinner = { "|", "/", "-", "\\" };
        int index = 0;

        while (DateTime.Now < endTime)
        {
            Console.WriteLine(spinner[index]);
            Console.Write("\b");
            index = (index + 1) % spinner.Length;
            Thread.Sleep(500);
        }
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i + "\b");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }

    public void SetDuration(int duration)
    {
        _duration = duration;
    }

    public int GetDuration()
    {
        return _duration;
    }
}
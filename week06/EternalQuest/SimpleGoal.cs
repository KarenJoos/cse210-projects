using System;

public class SimpleGoal : Goal
{
    private bool _IsComplete;

    public SimpleGoal(string shortName, string description, string points) : base(shortName, description, points)
    {

    }



    public override void RecordEvent()
    {
        Console.Write("What is the name of your goal? ");
        Console.ReadLine();
        Console.Write("What is a short description of it? ");
        Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        Console.ReadLine();
    }
    public override bool IsComplete()
    {
        bool yes = true;
        bool no = false;
        Console.WriteLine($"[ ] ");
        Console.WriteLine(no);
    }

    public override string GetStringRepresentation()
    {

    }
}
using System;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string shortName, string description, string points, int amountCompleted, int target, int bonus) : base(shortName, description, points)
    {
        _amountCompleted = amountCompleted;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {

    }

    public override bool IsComplete()
    {

    }

    public override string GetDetailsString()
    {

    }

    public override string GetStringRepresentation()
    {

    }
}
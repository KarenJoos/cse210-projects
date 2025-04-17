using System;

public abstract class Goal
{
    private string _shortName;
    private string _description;
    private string _points;

    public Goal(string shortName, string description, string points)
    {
        _shortName = shortName;
        _description = description;
        _points = points;
    }

    // This method should do whatever is necessary for each specific kind of goal, such as marking a simple goal complete and adding to the number of times a checklist goal has been completed. It should return the point value associated with recording the event (keep in mind that it may contain a bonus in some cases if a checklist goal was just finished, for example).
    public abstract void RecordEvent()
    {
        return;
    }

    // This method should return true if the goal is completed. The way you determine if a goal is complete is different for each type of goal.
    public abstract bool IsComplete()
    {
        return _points;
    }

    // This method should return the details of a goal that could be shown in a list. It should include the checkbox, the short name, and description. Then in the case of the ChecklistGoal class, it should be overridden to shown the number of times the goal has been accomplished so far.
    public string GetDetailsString()
    {
        return _description;
    }

    // This method should provide all of the details of a goal in a way that is easy to save to a file, and then load later.
    public abstract string GetStringRepresentation()
    {
        return _shortName;
    }
}
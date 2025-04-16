using System;

public abstract class Activity
{
    private string _date;
    private double _length;

    public Activity(string date, double length)
    {
        _date = date;
        _length = length;
    }

    public string GetDate()
    {
        
    }

    public abstract void GetDistance();

    public abstract void GetSpeed();


    public abstract int GetPace();
}
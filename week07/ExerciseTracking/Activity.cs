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
        DateTime currentTime = DateTime.Now;
        _date = currentTime.ToString();
        return _date;
    }

    public abstract void GetDistance(double length);

    public abstract void GetSpeed();


    public abstract int GetPace();
}
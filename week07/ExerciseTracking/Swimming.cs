using System;
using System.Diagnostics;

public class Swimming : Activity
{
    private int _laps;

    public Swimming(string date, double length) : base(date, length)
    {

    }

    public override void GetDistance()
    {
        distance = laps * 50 / 1000 * .62;
    }

    public abstract void GetSpeed();


    public abstract int GetPace();

}
using System;
using System.Diagnostics;

public class Swimming : Activity
{
    private int _laps;

    public Swimming(string date, double length, int laps) : base(date, length)
    {
        _laps = laps;
    }

    

}
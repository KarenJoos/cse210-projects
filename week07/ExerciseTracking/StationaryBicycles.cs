public class StationaryBicycles : Activity
{
    private int _laps;

    public StationaryBicycles(string date, double length, int laps) : base(date, length)
    {
        _laps = laps;
    }



}
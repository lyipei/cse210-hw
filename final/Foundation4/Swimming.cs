public class Swimming : Activity
{
    protected int _laps;
    public Swimming (string date, double minutes, int laps) : base (date, minutes)
    {
        _laps = laps;
    }
    public override double GetDistance()
    {
        return _laps * 50 / 1000.0 *0.62;
    }
    public override double GetSpeed()
    {
        return (GetDistance()/ _minutes) * 60;
    }
    public override double GetPace()
    {
        return _minutes / GetDistance();
    }
    public override string GetSummary()
    {
        return $"{_date} Swimming ({_minutes} min): Distance {GetDistance()} miles, Speed {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
}
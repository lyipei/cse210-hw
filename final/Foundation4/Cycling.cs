public class Cycling : Activity
{
    protected double _speed;
    public Cycling(string date, double minutes, double speed) : base (date, minutes)
    {
        _speed = speed;
    }
    public override double GetDistance()
    {
        return (_speed*_minutes) / 60;
    }
    public override double GetSpeed()
    {
        return _speed;
    }
    public override double GetPace()
    {
        return 60 / _speed;
    }
    public override string GetSummary()
    {
        return $"{_date} Cycling ({_minutes} min): Distance {GetDistance()} miles, Speed {GetSpeed()} mph, Pace: {GetPace()} min per mile";
    }
}
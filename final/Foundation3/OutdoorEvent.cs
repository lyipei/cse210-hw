public class OutdoorEvernt : Event
{
    private string _weatherStatement;
    public OutdoorEvernt(string title, string desc, Address address, string date, string time, string weatherStatement) : base(title, desc, address, date, time)
    {
        _weatherStatement = weatherStatement;
    }
    public override string GetFullDetails()
    {
        return base.GetFullDetails() + $"\nWeather: {_weatherStatement}";
    }
    public override string GetShortDescription()
    {
        return $"Outdoor Event: {_title} on {_date}";
    }

}
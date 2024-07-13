public class ReceptionEvent : Event
{
    private string _contactRSVP;
    public ReceptionEvent(string title, string desc, Address address, string date, string time, string contactRSVP) : base(title, desc, address, date, time)
    {
        _contactRSVP = contactRSVP;
    }
    public override string GetFullDetails()
    {
        return base.GetFullDetails()+ $"\nRSVP Contact: {_contactRSVP}";
    }
    public override string GetShortDescription()
    {
        return $"Reception: {_title} on {_date}";
    }
}
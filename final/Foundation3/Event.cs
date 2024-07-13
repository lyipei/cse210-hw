using System.Net.Sockets;

public class Event
{
    protected string _title;
    protected string _desc;
    protected Address _address;
    protected string _date;
    protected string _time;
    public Event(string title, string desc, Address address, string date, string time)
    {
        _title = title;
        _desc = desc;
        _address = address;
        _date = date;
        _time = time;
    }
    public string GetStandarDetails()
    {
        return $"Title: {_title}\nDescription: {_desc}\nDate: {_date}\nTime: {_time}\nAddress: {_address.GetAddressLabel()}";
    }
    public virtual string GetFullDetails()
    {
        return GetStandarDetails();
    }
    public virtual string GetShortDescription()
    {
        return $"Event: {_title} on {_date}";
    }

}
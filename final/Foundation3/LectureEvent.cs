public class LectureEvent : Event
{
    private string _speaker;
    private int _capacity;
    public LectureEvent(string title, string desc, Address address, string date, string time, string speaker, int capacity) : base (title, desc, address, date, time)
    {
        _speaker = speaker;
        _capacity = capacity;
    }
    public override string GetFullDetails()
    {
        return base.GetFullDetails() + $"\nSpeaker: {_speaker}\nCapacity: {_capacity}";
    }
    public override string GetShortDescription()
    {
        return $"Lecture: {_title} on {_date}";
    }
}
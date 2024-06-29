public class EternalGoal : Goal
{
    public EternalGoal(string name, int basePoints) : base(name, basePoints)
    {
        _targetProgress = int.MaxValue; 
    }

    public override void RecordProgress()
    {
        if (!_completed)
        {
            _currentProgress++;
        }
    }

    public override void DisplayProgress()
    {
        Console.WriteLine($"[ ] Eternal Goal: {_name}");
    }
}
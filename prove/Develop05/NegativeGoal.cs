public class NegativeGoal : Goal
{
    public NegativeGoal(string name, int basePoints, int penaltyPoints) 
        : base(name, basePoints, 0, penaltyPoints)
    {

        _targetProgress = penaltyPoints;
    }

    public override void DisplayProgress()
    {
        string status = _completed ? $"Failed due to penalty ({_currentProgress}/{_penaltyPoints})" 
                                   : $"[ ] {_name} {_currentProgress}/{_penaltyPoints}";
        Console.WriteLine(status);
    }

    public override void RecordProgress()
    {
        if (!_completed)
        {
            _currentProgress++;
            if (_currentProgress >= _penaltyPoints)
            {
                _completed = true;
                Console.WriteLine($"Goal '{_name}' failed due to penalty!");
            }
        }
    }
}
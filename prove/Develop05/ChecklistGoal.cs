public class ChecklistGoal : Goal
{

    public ChecklistGoal(string name, int basePoints, int targetProgress, int bonusPoints) : base(name, basePoints, bonusPoints)
    {
        _targetProgress = targetProgress;
    }

    public override void DisplayProgress()
    {
        string status = _completed ? $"Completed {_currentProgress}/{_targetProgress} times" : $"[ ] {_name} {_currentProgress}/{_targetProgress}";
        Console.WriteLine(status);
    }

    public override void RecordProgress()
    {
        if (!_completed)
        {
            _currentProgress++;
            if (_currentProgress >= _targetProgress)
            {
                _completed = true;
                Console.WriteLine($"Goal '{_name}' completed!");
            }
        }
    }
}
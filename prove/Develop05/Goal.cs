public abstract class Goal
{
    protected string _name;
    protected bool _completed;
    protected int _currentProgress;
    protected int _targetProgress;
    protected int _basePoints;
    protected int _bonusPoints;

    public string Name => _name;
    public bool Completed => _completed;

    protected Goal(string name, int basePoints, int bonusPoints = 0)
    {
        _name = name;
        _basePoints = basePoints;
        _bonusPoints = bonusPoints;
        _completed = false;
        _currentProgress = 0;
    }

    public virtual void RecordProgress()
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

    public abstract void DisplayProgress();

}
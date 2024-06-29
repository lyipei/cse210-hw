using System.Runtime.CompilerServices;

public class SimpleGoal : Goal
{
    public SimpleGoal(string name, int basePoints) : base(name, basePoints)
    {
        _targetProgress = 1;
    }

    public override void DisplayProgress()
    {
        string status = _completed ? "[X]" : "[ ]";
        Console.WriteLine($"{status} Simple Goal: {_name}");
    }
}
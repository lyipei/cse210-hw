using System.Diagnostics.CodeAnalysis;

abstract class Activity
{
    protected string _title;
    protected string _desc;
    protected int _duration;

    public Activity(string title, string desc)
    {
        _title = title;
        _desc = desc;
    }
    public void Start()
    {
        Console.WriteLine($"Starting {_title}");
        Console.WriteLine($"{_desc}");
        Console.WriteLine("Enter the duration of the activity in seconds: ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Prepare to begin...");
        Timer.PauseWithAnimation(5);

        RunActivity();

        Console.WriteLine();
        Console.WriteLine("Good Job!");
        Console.WriteLine($"You have completed {_title} for {_duration} seconds.");
        Timer.PauseWithAnimation(5);
        Console.Clear();

    }
    protected abstract void RunActivity();

}
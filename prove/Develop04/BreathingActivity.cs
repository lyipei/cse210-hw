class BreathingActivity : Activity
{
    public BreathingActivity()
        : base("Breathin Activity", 
                "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {}
    protected override void RunActivity()
    {
        Timer.Set(_duration);
        int breathDuration = 8;

        while (!Timer.IsExpired())
        {
            Console.Clear();
            Console.WriteLine("Breathe in...");
            DisplayProgressBar(breathDuration);
            Console.WriteLine("Breathe out...");
            DisplayProgressBar(breathDuration);
            Thread.Sleep(2000);
            Console.WriteLine();
        }
    }
    private void DisplayProgressBar(int duration)
    {
        int progressWidth = Console.WindowWidth - 20; // Adjust based on console window width
        int steps = 10;
        int delay = (duration * 1000) / steps;

        Console.Write(""); // Start of progress bar

        for (int i = 0; i < steps; i++)
        {
            Console.Write("=");
            Thread.Sleep(delay / steps);
        }

        Console.Write(""); // End of progress bar
        Console.WriteLine();
    }
    
}
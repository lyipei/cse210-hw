public static class Timer
{
    private static DateTime _targetTime;

    public static void Set(int seconds)
    {
        _targetTime = DateTime.Now.AddSeconds(seconds);
    }
    public static bool IsExpired()
    {
        return DateTime.Now >= _targetTime;
    }
    public static void PauseWithAnimation(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"\rPausing for {i} seconds...");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}
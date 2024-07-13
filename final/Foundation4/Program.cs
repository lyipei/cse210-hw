using System;

class Program
{
    static void Main()
    {
        List<Activity> activities = new List<Activity>
        {
            new Running("13 Jul 2024", 30, 3.0),
            new Cycling("13 Jul 2024", 30, 9.5),
            new Swimming("13 Jul 2024",30, 20 )

        };
        foreach (var activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}
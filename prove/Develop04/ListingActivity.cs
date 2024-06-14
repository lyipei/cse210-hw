class ListingActivity : Activity
{
    private static readonly List<string> Prompts = new List<string>
    {
        " --- Who are people that you appreciate?",
        " --- What are personal strengths of yours?",
        " --- Who are people that you have helped this week?",
        " --- When have you felt the Holy Ghost this month?",
        " --- Who are some of your personal heroes?"
    };
    public ListingActivity()
        : base("Listing Activity", 
               "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    { }
    protected override void RunActivity()
    {
        var random = new Random();
        string prompt = Prompts[random.Next(Prompts.Count)];
        Console.WriteLine();
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine(prompt);

        Thread.Sleep(500);
        Console.WriteLine("Start listing items: ");
        
        Timer.Set(_duration);
        List<string> items = new List<string>();
        while (!Timer.IsExpired())
            {
                Console.Write("> ");
                string item = Console.ReadLine();
                if (!string.IsNullOrEmpty(item))
                {
                    items.Add(item);
                }
        
            }
        Console.WriteLine($"You listed {items.Count} items.");

    }  
    
}

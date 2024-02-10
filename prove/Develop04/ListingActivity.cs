 class ListingActivity : MindfulnessActivity
{
    private List<string> prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity(int durationInSeconds, string description)
        : base(durationInSeconds, description)
    {
    }

    protected override void RunActivity()
    {
        Random random = new Random();
        string prompt = prompts[random.Next(prompts.Count)];
        Console.WriteLine($"\nPrompt: {prompt}");
        Console.WriteLine("You have several seconds to think and list your items...");

        Thread.Sleep(durationInSeconds * 1000);

        Console.WriteLine("\nActivity time is up!");
    }
}

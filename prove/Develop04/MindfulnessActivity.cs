abstract class MindfulnessActivity
{
    protected int durationInSeconds;
    protected string description;

    public MindfulnessActivity(int durationInSeconds, string description)
    {
        this.durationInSeconds = durationInSeconds;
        this.description = description;
    }

    public void Start()
    {
        DisplayStartingMessage();
        Thread.Sleep(3000); // Pause for a few seconds
        RunActivity();
        DisplayEndingMessage();
    }

    protected abstract void RunActivity();

    protected virtual void DisplayStartingMessage()
    {
        Console.WriteLine($"Starting {GetType().Name}: {description}");
        Console.WriteLine($"Duration: {durationInSeconds} seconds\n");
        Console.WriteLine("Prepare to begin...");
    }

    protected virtual void DisplayEndingMessage()
    {
        Console.WriteLine("\nCongratulations! You've completed the activity.");
        Console.WriteLine($"You've done a great job with {GetType().Name} for {durationInSeconds} seconds.");
    }
}

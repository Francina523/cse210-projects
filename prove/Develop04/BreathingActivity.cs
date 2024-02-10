class BreathingActivity : MindfulnessActivity
{
    public BreathingActivity(int durationInSeconds, string description)
        : base(durationInSeconds, description)
    {
    }

    protected override void RunActivity()
    {
        Console.WriteLine("\nBreathe in...");
        PauseWithSpinner();
        Console.WriteLine("Breathe out...");
        PauseWithSpinner();
        // Repeat until duration is reached
        int remainingTime = durationInSeconds - 2;
        while (remainingTime > 0)
        {
            Console.WriteLine("Breathe in...");
            PauseWithSpinner();
            Console.WriteLine("Breathe out...");
            PauseWithSpinner();
            remainingTime -= 2;
        }
    }

    private void PauseWithSpinner()
    {
        // Display a spinner animation while pausing
        for (int i = 0; i < 5; i++)
        {
            Console.Write("/");
            Thread.Sleep(200);
            Console.Write("\b");
            Console.Write("-");
            Thread.Sleep(200);
            Console.Write("\b");
            Console.Write("\\");
            Thread.Sleep(200);
            Console.Write("\b");
            Console.Write("|");
            Thread.Sleep(200);
            Console.Write("\b");
        }
    }
}

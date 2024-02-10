 class ReflectionActivity : MindfulnessActivity
{
    private List<string> prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public ReflectionActivity(int durationInSeconds, string description)
        : base(durationInSeconds, description)
    {
    }

    protected override void RunActivity()
    {
        Random random = new Random();
        int remainingTime = durationInSeconds;

        while (remainingTime > 0)
        {
            string prompt = prompts[random.Next(prompts.Count)];
            Console.WriteLine($"\nPrompt: {prompt}");
            PauseWithSpinner();

            foreach (string question in questions)
            {
                Console.WriteLine($"\nQuestion: {question}");
                PauseWithSpinner();
            }

            remainingTime -= questions.Count;
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
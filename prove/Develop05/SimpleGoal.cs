public class SimpleGoal : Goal
{
    public SimpleGoal(string name, int points) : base(name, points) { }

    public override void DisplayProgress()
    {
        Console.WriteLine($"[ ] {name}");
    }
}

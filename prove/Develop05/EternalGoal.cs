public class EternalGoal : Goal
{
    public EternalGoal(string name, int points) : base(name, points) { }

    public override int Complete()
    {
        return base.Complete();
    }

    public override void DisplayProgress()
    {
        Console.WriteLine($"[ ] {name}");
    }
}
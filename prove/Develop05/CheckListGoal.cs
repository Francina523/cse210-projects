 public class ChecklistGoal : Goal
{
    private int targetTimes;
    private int completedTimes;
    private int bonusPoints;

    public ChecklistGoal(string name, int points, int targetTimes, int bonusPoints) : base(name, points)
    {
        this.targetTimes = targetTimes;
        this.bonusPoints = bonusPoints;
    }

    public override int Complete()
    {
        completedTimes++;
        if (completedTimes >= targetTimes)
        {
            return base.Complete() + bonusPoints;
        }
        return base.Complete();
    }

    public override void DisplayProgress()
    {
        Console.WriteLine($"[ ] {name} (Completed {completedTimes}/{targetTimes} times)");
    }
}
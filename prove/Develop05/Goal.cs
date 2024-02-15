 public abstract class Goal
{
    protected string name;
    protected int points;
    protected bool completed;

    public Goal(string name, int points)
    {
        this.name = name;
        this.points = points;
        completed = false;
    }

    public virtual int Complete()
    {
        completed = true;
        return points;
    }

    public abstract void DisplayProgress();
}
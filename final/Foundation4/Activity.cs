class Activity
{
    protected DateTime Date { get; }
    protected int Minutes { get; }

    public Activity(DateTime date, int minutes)
    {
        Date = date;
        Minutes = minutes;
    }

    public virtual double GetDistance()
    {
        throw new NotImplementedException();
    }

    public virtual double GetSpeed()
    {
        throw new NotImplementedException();
    }

    public virtual double GetPace()
    {
        throw new NotImplementedException();
    }

    public virtual string GetSummary()
    {
        return $"{Date.ToShortDateString()} - Activity";
    }
}

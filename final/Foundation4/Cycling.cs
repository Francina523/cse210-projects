class Cycling : Activity
{
    private double Speed;

    public Cycling(DateTime date, int minutes, double speed) : base(date, minutes)
    {
        Speed = speed;
    }

    public override double GetDistance()
    {
        return Speed * Minutes / 60;
    }

    public override double GetSpeed()
    {
        return Speed;
    }

    public override double GetPace()
    {
        return 60 / Speed;
    }
    public override string GetSummary()
    {
        return $"{base.GetSummary()} - Speed: {Speed} mph, Distance: {GetDistance()} miles, Pace: {GetPace()} min per mile";
    }
}
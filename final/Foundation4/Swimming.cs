class Swimming : Activity
{
    private int Laps;

    public Swimming(DateTime date, int minutes, int laps) : base(date, minutes)
    {
        Laps = laps;
    }

    public override double GetDistance()
    {
        return Laps * 50 / 1000 * 0.62;
    }

    public override double GetSpeed()
    {
        return Laps * 50 / 1000 / Minutes * 60;
    }

    public override double GetPace()
    {
        return Minutes / (Laps * 50 / 1000 * 0.62);
    }
    public override string GetSummary()
    {
        return $"{base.GetSummary()} - Laps: {Laps}, Distance: {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min per km";
    }
}
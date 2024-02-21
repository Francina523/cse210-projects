 class Goal
{
    protected string _shortName;
    protected string _description;
    protected int _points;

    public Goal() { } // Parameterless constructor required for deserialization

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public string ShortName
    {
        get { return _shortName; }
        set { _shortName = value; }
    }

    public int Points
    {
        get { return _points; }
        set { _points = value; }
    }


    public virtual void RecordEvent()
    {
        // Record event logic here
    }

    public virtual bool IsComplete()
    {
        // Completion logic here
        return false;
    }

    public virtual string GetDetailsString()
    {
        return $"{_shortName}: {_description} - {_points} points";
    }

    public virtual string GetStringRepresentation()
    {
        return $"{_shortName} - {_points} points";
    }
}

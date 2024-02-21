class SimpleGoal : Goal
{
     public SimpleGoal() { } // Parameterless constructor required for deserialization
    protected bool _isComplete;

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;
    }

    public override void RecordEvent()
    {
        _isComplete = true;
        // Add points to the player's score
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        return base.GetStringRepresentation() + (_isComplete ? " - Completed" : " - Incomplete");
    }
}

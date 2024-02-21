class EternalGoal : Goal
{
     public EternalGoal() { } // Parameterless constructor required for deserialization
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
    }

    public override void RecordEvent()
    {
        // Add points to the player's score
    }

    public override bool IsComplete()
    {
        return false; // Eternal goals are never complete
    }
}
 class ChecklistGoal : Goal
{
    public ChecklistGoal() { } // Parameterless constructor required for deserialization
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        _amountCompleted++;
        // Add points to the player's score
        if (_amountCompleted == _target)
        {
            // Add bonus points to the player's score
        }
    }
    public override bool IsComplete()
    {
        return _amountCompleted == _target;
    }

    public override string GetDetailsString()
    {
        return $"{_shortName}: {_description} - {_points} points, Completed {_amountCompleted}/{_target} times";
    }
}
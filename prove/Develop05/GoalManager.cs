using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
class GoalManager
{
    private List<Goal> goals = new List<Goal>();
    private int _score;

    public GoalManager()
    {
        _score = 0;
    }

    public void Start()
    {
        // Start logic
    }

    public void DisplayPlayerInfo()
    {
        // Display player info
    }

    public void ListGoalNames()
    {
    foreach (var goal in goals)
    {
        Console.WriteLine(goal.ShortName); // Access _shortName through the property
    }
    }
    public void RecordEvent(string goalName)
    {
    foreach (var goal in goals)
    {
        if (goal.ShortName == goalName) // Assuming ShortName property is added as well
        {
            goal.RecordEvent();
            _score += goal.Points; // Access _points through the property
        }
    }
    }
    public void ListGoalDetails()
    {
        foreach (var goal in goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    public void CreateGoal(Goal goal)
    {
        goals.Add(goal);
    }

    public void SaveGoals(string fileName)
    {
        // Serialize goals to JSON
        string jsonString = JsonSerializer.Serialize(goals);

        // Write JSON to file
        File.WriteAllText(fileName, jsonString);
    }

    public void LoadGoals(string fileName)
    {
        // Read JSON from file
        string jsonString = File.ReadAllText(fileName);

        // Deserialize JSON to List<Goal>
        goals = JsonSerializer.Deserialize<List<Goal>>(jsonString);
    }

    public void DisplayScore()
    {
        Console.WriteLine($"Current Score: {_score}");
    }
}

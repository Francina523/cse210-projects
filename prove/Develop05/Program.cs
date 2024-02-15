using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace EternalQuest
{
    class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();

        // Adding goals
        goalManager.AddGoal(new SimpleGoal("Run a Marathon", 1000));
        goalManager.AddGoal(new EternalGoal("Read Scriptures", 100));
        goalManager.AddGoal(new ChecklistGoal("Attend Temple", 50, 10, 500));

        // Simulating events
        goalManager.RecordEvent(0); // Run a Marathon
        goalManager.RecordEvent(1); // Read Scriptures
        goalManager.RecordEvent(2); // Attend Temple

        // Displaying goals and score
        goalManager.DisplayGoals();
        goalManager.DisplayScore();

        // Saving progress
        goalManager.SaveProgress("progress.json");

        // Loading progress
        GoalManager loadedGoalManager = new GoalManager();
        loadedGoalManager.LoadProgress("progress.json");

        // Displaying loaded goals and score
        loadedGoalManager.DisplayGoals();
        loadedGoalManager.DisplayScore();
    }
}
}
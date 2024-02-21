using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
class Program
{
    static void Main()
    {
        GoalManager goalManager = new GoalManager();

        SimpleGoal runMarathonGoal = new SimpleGoal("Run a marathon", "Complete a full marathon", 1000);
        EternalGoal readScripturesGoal = new EternalGoal("Read scriptures", "Read scriptures daily", 100);
        ChecklistGoal attendTempleGoal = new ChecklistGoal("Attend temple", "Visit the temple", 50, 10, 500);

        goalManager.CreateGoal(runMarathonGoal);
        goalManager.CreateGoal(readScripturesGoal);
        goalManager.CreateGoal(attendTempleGoal);

        goalManager.RecordEvent("Run a marathon");
        goalManager.RecordEvent("Read scriptures");
        goalManager.RecordEvent("Attend temple");
        goalManager.RecordEvent("Attend temple");

        goalManager.ListGoalDetails();
        goalManager.DisplayScore();

        goalManager.SaveGoals("goals.dat");

        GoalManager newGoalManager = new GoalManager();
        newGoalManager.LoadGoals("goals.dat");

        newGoalManager.ListGoalDetails();
        newGoalManager.DisplayScore();
    }
}
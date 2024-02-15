using Newtonsoft.Json;
public class GoalManager
{
    private List<Goal> goals;
    private int score;

    public GoalManager()
    {
        goals = new List<Goal>();
        score = 0;
    }

    public void AddGoal(Goal goal)
    {
        goals.Add(goal);
    }

    public void RecordEvent(int goalIndex)
    {
        if (goalIndex >= 0 && goalIndex < goals.Count)
        {
            score += goals[goalIndex].Complete();
            Console.WriteLine($"Congratulations! You completed the goal: {goals[goalIndex]}");
        }
        else
        {
            Console.WriteLine("Invalid goal index.");
        }
    }

    public void DisplayGoals()
    {
        Console.WriteLine("Your Goals:");
        foreach (var goal in goals)
        {
            goal.DisplayProgress();
        }
    }

    public void DisplayScore()
    {
        Console.WriteLine($"Your Score: {score}");
    }

    public void SaveProgress(string fileName)
    {
        using (StreamWriter file = File.CreateText(fileName))
        {
            JsonSerializer serializer = new JsonSerializer();
            serializer.Serialize(file, goals);
        }
    }

    public void LoadProgress(string fileName)
    {
        using (StreamReader file = File.OpenText(fileName))
        {
            JsonSerializer serializer = new JsonSerializer();
            goals = (List<Goal>)serializer.Deserialize(file, typeof(List<Goal>));
        }
    }
}

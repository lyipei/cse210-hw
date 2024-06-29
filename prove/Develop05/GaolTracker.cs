public class GoalTracker
{
    private List<Goal> _goals;

    public GoalTracker()
    {
        _goals = new List<Goal>();
    }

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void DisplayGoals()
    {
        Console.WriteLine("Current Goals:");
        foreach (var goal in _goals)
        {
            goal.DisplayProgress();
        }
    }
    public void ApplyPenalty(string goalName)
    {
        var goal = _goals.FirstOrDefault(g => g.Name == goalName);
        if (goal != null && goal is NegativeGoal)
        {
            goal.ApplyPenalty();
        }
        else
        {
            Console.WriteLine($"Goal '{goalName}' cannot receive penalties or not found.");
        }
    }

    public void RecordEvent(string goalName)
    {
        var goal = _goals.FirstOrDefault(g => g.Name == goalName);
        if (goal != null)
        {
            goal.RecordProgress();
        }
        else
        {
            Console.WriteLine($"Goal '{goalName}' not found.");
        }
    }

    public void SaveProgress(string fileName)
    {
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            foreach (var goal in _goals)
            {
                writer.WriteLine($"{goal.GetType().Name},{goal.Name},{goal.Completed},{goal.DisplayProgress}");
            }
        }
    }

    public void LoadProgress(string fileName)
    {
        _goals.Clear();
        using (StreamReader reader = new StreamReader(fileName))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                string[] parts = line.Split(',');
                if (parts.Length >= 5)
                {
                    string type = parts[0];
                    string name = parts[1];
                    bool completed = bool.Parse(parts[2]);
                    int currentProgress = int.Parse(parts[3]);
                    int targetProgress = int.Parse(parts[4]);
                    int bonusPoints = int.Parse(parts[5]);

                    Goal goal;
                    if (type == nameof(SimpleGoal))
                    {
                        goal = new SimpleGoal(name, bonusPoints);
                    }
                    else if (type == nameof(EternalGoal))
                    {
                        goal = new EternalGoal(name, bonusPoints);
                    }
                    else if (type == nameof(ChecklistGoal))
                    {
                        goal = new ChecklistGoal(name, bonusPoints, targetProgress, bonusPoints);
                    }
                    else
                    {
                        continue; 
                    }

                    goal.RecordProgress();
                    _goals.Add(goal);
                }
            }
        }
    }
}

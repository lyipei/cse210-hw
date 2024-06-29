using System;
using System.Transactions;


class Program
{
    static void Main(string[] args)
    {
        GoalTracker tracker = new GoalTracker();

        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("\n===== Goal Tracker Menu =====");
            Console.WriteLine("  1. Display Goals");
            Console.WriteLine("  2. Record Event");
            Console.WriteLine("  3. Save Progress");
            Console.WriteLine("  4. Load Progress");
            Console.WriteLine("  5. Add New Goal");
            Console.WriteLine("  6. Exit");

            Console.Write("\nEnter your choice (1-6): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("\n=== Current Goals ===");
                    tracker.DisplayGoals();
                    break;
                case "2":
                    Console.Write("\nEnter the name of the goal to record event: ");
                    string goalName = Console.ReadLine();
                    tracker.RecordEvent(goalName);
                    break;
                case "3":
                    Console.Write("\nEnter the file name to save progress (e.g., goals.txt): ");
                    string saveFileName = Console.ReadLine();
                    tracker.SaveProgress(saveFileName);
                    Console.WriteLine($"Progress saved to '{saveFileName}'.");
                    break;
                case "4":
                    Console.Write("\nEnter the file name to load progress from (e.g., goals.txt): ");
                    string loadFileName = Console.ReadLine();
                    tracker.LoadProgress(loadFileName);
                    Console.WriteLine($"Progress loaded from '{loadFileName}'.");
                    break;
                case "5":
                    Console.WriteLine("\n=== Add New Goal ===");
                    Console.Write("Enter goal name: ");
                    string newGoalName = Console.ReadLine();
                    Console.Write("Enter base points for the goal: ");
                    int basePoints = int.Parse(Console.ReadLine());
                    Console.Write("Enter bonus points (0 if none): ");
                    int bonusPoints = int.Parse(Console.ReadLine());
                    Console.Write("Enter target progress (1 for simple/eternal, or number of times for checklist): ");
                    int targetProgress = int.Parse(Console.ReadLine());

                    Goal newGoal;
                    if (targetProgress == 1)
                    {
                        newGoal = new SimpleGoal(newGoalName, basePoints);
                    }
                    else if (targetProgress == int.MaxValue)
                    {
                        newGoal = new EternalGoal(newGoalName, basePoints);
                    }
                    else
                    {
                        newGoal = new ChecklistGoal(newGoalName, basePoints, targetProgress, bonusPoints);
                    }

                    tracker.AddGoal(newGoal);
                    Console.WriteLine($"New goal '{newGoalName}' added.");
                    break;
                case "6":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter a number from 1 to 6.");
                    break;
            }
        }

        Console.WriteLine("\nProgram ended. Thank you for using the Goal Tracker!");
    }
    
}    
using System;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;
    public int Score => _score;
    public void CreateGoal()
    {
        Console.WriteLine(" 1. Simple Goal ");
        Console.WriteLine(" 2. Eternal Goal ");
        Console.WriteLine(" 3. Checklist Goal ");
        Console.Write("Which type of the goal are you doign today: ");
        string typeInput = Console.ReadLine();

        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();

        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();

        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());
       
        Goal newGoal = null;

        if (typeInput == "1")
        {
            newGoal = new SimpleGoal(name, description, points);
        }
        else if (typeInput == "2")
        {
            newGoal = new EternalGoal(name, description, points);
        }
        else if (typeInput == "3")
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            if (!int.TryParse(Console.ReadLine(), out int target))
            {
                Console.WriteLine("Invalid number.");
                return;
            }

            Console.Write("What is the bonus points for accomplishing it that many times? ");
            if (!int.TryParse(Console.ReadLine(), out int bonus))
            {
                Console.WriteLine("Invalid number.");
                return;
            }

            newGoal = new ChecklistGoal(name, description, points, target, bonus);
        }
        else
        {
            Console.WriteLine("Invalid choice. ");
            return;
        }

        _goals.Add(newGoal);
        Console.WriteLine("Goal added successfully");

    }
    public void ListGoals()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals have been created yet. ");
            return;
        }

        Console.WriteLine("The goals are:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"  {i + 1}. {_goals[i].GetDetailsString()}");
        }
    }
    public void RecordEvent()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals to record.");
            return;
        }
        ListGoals();
        Console.Write("Which goal did you accomplish? Enter the number:");
        if (!int.TryParse(Console.ReadLine(), out int choice) || choice < 1 || choice > _goals.Count)
        {
            Console.WriteLine("Invalid selection.");
            return;
        }
        Goal selected = _goals[choice - 1];
        selected.RecordEvent();
        int earned = selected.GetPoints();
        _score += earned;
        Console.WriteLine($"You earned {earned} points! total score: {_score}");
    }

    public void SaveGoals()
    {
        Console.Write("What would you like to save this as? ");
        string filename = Console.ReadLine();

        if (string.IsNullOrEmpty(filename))
        {
            Console.WriteLine("No filename entered.");
            return;
        }

        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(_score);

            foreach (Goal g in _goals)
            {
                writer.WriteLine(g.GetStringRepresentation());
            }
        }

        Console.WriteLine("Saved!");
    }
    public void LoadGoals()
    {
        Console.Write("What is the filename you are looking for? ");
        string filename = Console.ReadLine();

        if (string.IsNullOrEmpty(filename) || !File.Exists(filename))
        {
            Console.WriteLine("File not found.");
            return;
        }

        _goals.Clear();

        string[] lines = File.ReadAllLines(filename);

        if (lines.Length == 0)
        {
            Console.WriteLine("File is empty.");
            return;
        }

        _score = int.Parse(lines[0]);
        for (int i = 1; i < lines.Length; i++)
        {
            string line = lines[i].Trim();
        if (string.IsNullOrEmpty(line)) continue;

        // Split on the FIRST colon only
        string[] typeAndData = line.Split(',', 2);

        if (typeAndData.Length != 2) continue;

        string goalType = typeAndData[0];
        string data = typeAndData[1];

        Goal newGoal = null;

        if (goalType == "SimpleGoal")
        {
            newGoal = new SimpleGoal(data);   
        }
        else if (goalType == "EternalGoal")
        {
            newGoal = new EternalGoal(data);
        }
        else if (goalType == "ChecklistGoal")
        {
            newGoal = new ChecklistGoal(data);
        }

        if (newGoal != null)
        {
            _goals.Add(newGoal);
        }
    }

        Console.WriteLine($"Loaded {_goals.Count} goals and {_score} points.");
    }
    public void AddPoints(int points)
    {
        _score += points;
    }
}

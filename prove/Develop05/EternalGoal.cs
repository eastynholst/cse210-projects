using System;

public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
    }
     public override void RecordEvent()
    {
        Console.WriteLine($"Great Job! You earned {_points} points");
        Console.WriteLine("Hope to see you again!");
    }
    public override bool IsComplete() => false;
    public override string GetDetailsString()
    {
        return $"[] {_shortName} ({_description}) - Eternal";
    }
    public override string GetStringRepresentation()
    {
        return $"EternalGoal,{_shortName},{_description},{_points}";
    }
    public EternalGoal(string saveString) : base("","",0)
    {
        string[] parts = saveString.Split(',');
        _shortName = parts[0];
        _description = parts[1];
        _points = int.Parse(parts[2]);
    }
}
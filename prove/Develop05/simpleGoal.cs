using System;

public class SimpleGoal : Goal
{
    protected bool _isComplete = false;

    public SimpleGoal(string name, string description, int points, bool isComplete = false) : base(name, description, points)
    {
        _isComplete = isComplete;
    }
    public override void RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            Console.WriteLine($"COngratulations!!! You earned {_points} points");
        }
        else
        {
            Console.WriteLine("This goal is already done");
        }
    }
    public override bool IsComplete() => _isComplete;
    public override string GetDetailsString()
    {
        string check = IsComplete() ? "[✓]" : "[ ]";
        return $"{check} {_shortName} ({_description})";
    }
    public override string GetStringRepresentation()
    {
        return $"SimpleGoal,{_shortName},{_description},{_points},{(_isComplete ? "1" : "0")}";
    }
    
    public SimpleGoal(string saveString) : base("","",0)
    {
        string[] parts = saveString.Split(',');
        _shortName = parts[0];
        _description = parts[1];
        _points = int.Parse(parts[2]);
        _isComplete = parts[3] == "1";
    }
    
}
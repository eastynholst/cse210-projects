using System;

public class ChecklistGoal : Goal
{
    protected int _amountCompleted = 0;
    protected int _targetCount;
    protected int _bonusPoints;

    public ChecklistGoal(string name, string description, int points, int target, int bonus, int amountCompleted = 0) : base(name, description, points)
    {
        _targetCount = target;
        _bonusPoints = bonus;
       _amountCompleted = amountCompleted;
    }
    public override void RecordEvent()
    {
        _amountCompleted++;

        int earned = _points;
        Console.WriteLine($"You earned {earned} points");

        if (_amountCompleted >= _targetCount)
        {
            earned += _bonusPoints;
            Console.WriteLine($"Bonus You earned an extra {_bonusPoints} points for completeing the goal fast");
        }
        Console.WriteLine($"Total this time: {earned} points");
    }
     public override bool IsComplete()
    {
        return _amountCompleted >= _targetCount;
    }
    public override string GetDetailsString()
    {
        string check = IsComplete() ? "[✓]" : "[ ]";
        return $"{check} {_shortName} ({_description}) --> {_amountCompleted}/{_targetCount}";
    }
    public override string GetStringRepresentation()
    {
        return $"ChecklistGoal,{_shortName},{_description},{_points},{_targetCount},{_bonusPoints},{_amountCompleted}";
    }
    public ChecklistGoal(string saveString) : base("","",0)
    {
        string[] parts = saveString.Split(',');
        _shortName = parts[0];
        _description = parts[1];
        _points = int.Parse(parts[2]);
        _targetCount = int.Parse(parts[3]);
        _bonusPoints = int.Parse(parts[4]);
        _amountCompleted = int.Parse(parts[5]);
    }
}
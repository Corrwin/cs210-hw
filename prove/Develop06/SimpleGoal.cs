using System;

public class SimpleGoal : Goal{
    private bool _isComplete = false;


    public SimpleGoal(string name, string description, int points, bool isComplete) : base(name, description, points){
        _name = name;
        _description = description;
        _points = points;
        _isComplete = isComplete;
    }

    public override void  RecordEvent(){
        Console.WriteLine($"Congrats! You earned {_points} points!");
        _isComplete = true;
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        string _representation = "SimpleGoal:" + _name + ":" + _description + $":{_points}:" + _isComplete;
        return _representation;
    }
}
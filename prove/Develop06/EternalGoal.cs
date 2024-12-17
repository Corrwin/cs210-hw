using System;

public class EternalGoal : Goal{
    public EternalGoal(string name, string description, int points): base(name, description, points){
        _name = name;
        _description = description;
        _points = points;
    }

    public override void RecordEvent(){
        Console.WriteLine($"Congrats! You earned {_points} points!");
    }

    public override bool isComplete() 
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        string _representation = "Name: " + _name + "\nDescription: " + _description;
        return _representation;
    }
}
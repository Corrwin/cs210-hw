using System;

public class SimpleGoal : Goal{
    bool _isComplete;


    public SimpleGoal(string name, string description, int points) : base(name, description, points){
        _name = name;
        _description = description;
        _points = points;
    }

    public class RecordEvent(){

    }
}
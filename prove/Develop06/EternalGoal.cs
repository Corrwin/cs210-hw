using System;

public class EternalGoal : Goal{
    public EternalGoal(string name, string description, int points): base(name, description, points){
        _name = name;
        _description = description;
        _points = points;
    }

    public override void RecordEvent(){
        
    }

    public override bool isComplete()
    {
        throw new NotImplementedException();
    }
}
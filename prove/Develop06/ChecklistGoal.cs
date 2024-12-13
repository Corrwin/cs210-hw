using System;

public class ChecklistGoal : Goal{
    int _amountCompleted;
    int _target;
    int _bonus;



    public  ChecklistGoal(string name, string description, int points, int target, int bonus): base(name, description, points){
        _name = name;
        _description = description;
        _points = points;
        _target = target;
        _bonus = bonus;
    }


    public class RecordEvent(){
        
    }
}
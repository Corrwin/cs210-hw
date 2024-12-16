using System;
using System.Runtime;

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


    public override void RecordEvent(){
        _amountCompleted++;
        Console.WriteLine($"You have completeed this task {_amountCompleted} of of {_target} times.");
    }

    public override bool isComplete()
    {
        if (_amountCompleted >= _target){
            return true;
        }
        else {return false;}
    }

    
    public override string GetDetailsString(){
        string _details = "Name: " + _name + "\nDescription: " + _description + $"\nTimes Completed: {_amountCompleted} \n";
        //ADD CHECK BOX HERE
        return _details;
    }

    public override string GetStringRepresentation()
    {
        string _representation = "Name: " + _name + "\nDescription: " + _description + $"\nTimes Completed: {_amountCompleted} \n";
        return _representation;
    }
}
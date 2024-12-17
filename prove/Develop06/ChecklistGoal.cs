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
        Console.WriteLine($"Congrats! You earned {_points} points!");
        _amountCompleted++;
        Console.WriteLine($"You have completed {_name} {_amountCompleted} of {_target} times.");
    }

    public override bool IsComplete()
    {
        if (_amountCompleted >= _target){
            return true;
        }
        else {return false;}
    }

    
    public override string GetDetailsString(){
        string _details = "";
        if (IsComplete()){
             _details = "[X]" + _name + "(" + _description + $") - times Completed: {_amountCompleted}/{_target}  \n";
        }
        else {
             _details = "[ ]" + _name + "(" + _description + $") - times Completed: {_amountCompleted}/{_target} \n";
        }
        
        return _details;
    }

    public override string GetStringRepresentation()
    {
        string _representation = "ChecklistGoal\n" + _name + "\n" + _description + $"\n{_points}\n{_target}\n{_bonus}";
        return _representation;
    }
}
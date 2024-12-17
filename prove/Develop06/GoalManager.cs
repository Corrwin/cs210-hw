using System;
using System.IO;

public class GoalManager(){
    List<Goal> _goals = new List<Goal>();
    int _score = 0;

    public void DisplayPlayerInfo(){
        Console.WriteLine($"You have {_score} points.");
    }

    public void ListGoalNames(){
        foreach (Goal goal in _goals){
            Console.WriteLine(goal.GetName());
        }
    }

    public void ListGoalDescriptions(){
        int i = 0;
        while (i < _goals.Count()){
            Console.WriteLine($"{i}. " + _goals[i].GetDetailsString()); 
            i++;
        }
    }

    public void CreateGoal(){
        Console.WriteLine("What Kind of Goal would you like to make?\n1. Simple Goal\n 2.Eternal Goal\n3.Checklist Goal");
        int _userInput = Int32.Parse(Console.ReadLine());
        Console.WriteLine("What is the name of your goal?");
        string _tempName = Console.ReadLine();
        Console.WriteLine("Give a short description of your goal:");
        string _tempDesc = Console.ReadLine();
        Console.WriteLine("How many points is this goal worth?");
        int _tempPoint = Int32.Parse(Console.ReadLine());

        if (_userInput == 1){
            _goals.Add(new SimpleGoal(_tempName, _tempDesc, _tempPoint));
        }   

        if (_userInput == 2){
            _goals.Add(new EternalGoal(_tempName, _tempDesc, _tempPoint));
        }

        if (_userInput == 3){
            Console.WriteLine("How many times would you like to repeat this goal?");
            int _tempRepeat =Int32.Parse(Console.ReadLine());
            Console.WriteLine("How many points do you get for completing it that many times?");
            int _tempBonus =Int32.Parse(Console.ReadLine());
            _goals.Add(new ChecklistGoal(_tempName, _tempDesc, _tempPoint, _tempRepeat, _tempBonus));
        }
        else{Console.WriteLine("Error, bad input. Starting over.");}
    }

    public void RecordEvent(){
        Console.WriteLine("Which Goal would you like to record?");
        ListGoalDescriptions();
        int _userInput = Int32.Parse(Console.ReadLine());
        _goals[_userInput].RecordEvent();
        DisplayPlayerInfo();
    }

    public void SaveGoals(){
        Console.WriteLine("Please input file name:");
        string _saveLocation = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(_saveLocation)){
            foreach (Goal goal in _goals){
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
    }


    public void LoadGoals(){
        
    }
}
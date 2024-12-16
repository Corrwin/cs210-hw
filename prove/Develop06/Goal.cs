using System;

public abstract class Goal{
   protected string _name;
   protected string _description;
   protected int _points;

    protected  Goal(string name, string description, int points){
        _name = name;
        _description = description;
        _points = points;
    }

    public abstract void RecordEvent();

    public abstract bool isComplete();

    public abstract string GetStringRepresentation();

    public string GetDetailsString(){
        return _description;
    }
}
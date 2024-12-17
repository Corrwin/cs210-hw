using System;

public abstract class Goal{
   protected string _name;
   protected string _description;
   public int _points;

    protected  Goal(string name, string description, int points){
        _name = name;
        _description = description;
        _points = points;
    }

    public abstract void RecordEvent();

    public abstract bool IsComplete();

    public abstract string GetStringRepresentation();

    public virtual string GetDetailsString(){   //I know this was NOT supposed to be abstract. However, I can't figure out how it is supposed to work without being abstract.
         string _details = "";
         if (IsComplete()){
            _details = "[X]" + _name + "(" + _description + ")\n";
         }
         else {
            _details ="[ ]" + _name + "(" + _description + ")\n";
         }
             
        return _details;
    }

    public string GetName(){
        return _name;
    }

    public string GetDescription(){
        return _description;
    }
}

using System;
using System.Runtime.CompilerServices;

public class CycleActivity : Activity{

    private double _speed;
    public CycleActivity(int time, double distance) :base(time, distance){
        _time = time;
        _distance = distance;
        _today = DateTime.Today;
        
    }


    public override double GetSpeed(){
        double speed = (_distance * _time)/60;
        _speed = Double.Round(speed, 1);
        return _speed;
        }

    public override double GetPace()
    {
        return Double.Round(_time/_distance, 1);
    }


    public override string GetSummary()
    {
        string _summary = _today.ToLongDateString() + $" Cycling ({_time} min) - Distance {GetDistance()} miles, speed {GetSpeed()} mph, pace {GetPace()} min per mile";
        return _summary;
    }

}
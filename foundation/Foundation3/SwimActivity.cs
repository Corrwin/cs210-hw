using System;

public class SwimActivity : Activity{
    private double _laps;

    public SwimActivity(int time, double distance) :base(time, distance){
        _time = time;
        _distance = distance;
        _today = DateTime.Today;
        _laps = distance * 20;
    }


    public override double GetSpeed(){
        double speed = (_distance * _time)/60;
        return Double.Round(speed, 1);
        }

    public override double GetPace()
    {
        return Double.Round(_time/_distance, 1);
    }


    public override string GetSummary()
    {
        string _summary = _today.ToLongDateString() + $" Swimming ({_time} min) - Distance {GetDistance()} kilometers, speed {GetSpeed()} kmph, laps {GetPace()}";
        return _summary;

    }

}
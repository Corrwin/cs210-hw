using System;

public class RunActivity : Activity{

    public RunActivity(int time, double distance) :base(time, distance){
        _time = time;
        _distance = distance;
        _today = DateTime.Today;
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
        string _summary = _today.ToString() + $" Running ({_time} min) - Distance {GetDistance()} miles, speed {GetSpeed()} mph, pace {GetPace()} min per mile";
        return _summary;

    }

}
using System;
using System.Diagnostics;

public abstract class Activity(){
    protected int _time;
    protected double _distance;

    protected DateTime _today; //= DateTime.Today

    protected Activity(int time, double distance) :this(){
        _time = time;
        _distance = distance;
    }

    public virtual double GetSpeed(){
        double _hourFraction = _time/60;
        double speed = _distance/_hourFraction;
        return speed;
    }

    public abstract double GetPace();

    public abstract string GetSummary();

    public  double GetDistance(){
        return _distance;
    }
}
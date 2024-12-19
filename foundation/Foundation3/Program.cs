using System;

class Program
{
    static void Main(string[] args)
    { 
        CycleActivity c1 = new CycleActivity(40, 12);
        RunActivity r1 = new RunActivity(32, 7);
        SwimActivity s1 = new SwimActivity(40, 0.8);


        List<Activity> a1 = new List<Activity>();
        a1.Add(c1);
        a1.Add(r1);
        a1.Add(s1);


        foreach (Activity activity in a1){
            Console.WriteLine(activity.GetSummary());
        }
    }
}
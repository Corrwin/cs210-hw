using System;

class Program
{
    static void Main(string[] args)
    { 
        CycleActivity c1 = new CycleActivity(40, 12);
        RunActivity r1 = new RunActivity(32, 7);


        Console.WriteLine(r1.GetSummary());
        Console.WriteLine(c1.GetSummary());
    }
}
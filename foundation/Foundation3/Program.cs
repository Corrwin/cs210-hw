using System;

class Program
{
    static void Main(string[] args)
    { 
        RunActivity r1 = new RunActivity(30, 5);
        Console.WriteLine(r1.GetSummary());
    }
}
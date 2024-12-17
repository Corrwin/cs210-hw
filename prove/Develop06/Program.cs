using System;

class Program
{
    static void Main(string[] args)
    {
        SimpleGoal s1 = new SimpleGoal("Test Simple", "Simply a test", 50);
        EternalGoal e1 = new EternalGoal("Test Eternal", "Eternally a test", 10);
        ChecklistGoal c1 = new ChecklistGoal("Test Simple", "Simply a test", 20, 3, 500);

        s1.RecordEvent();
        Console.WriteLine(s1.GetStringRepresentation());
        Console.WriteLine(s1.GetDetailsString());

        Console.WriteLine(c1.GetDetailsString());
        Console.WriteLine(c1.GetStringRepresentation());

        Console.WriteLine(e1.GetDetailsString());
        Console.WriteLine(e1.GetStringRepresentation());
    }
}
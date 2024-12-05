using System;
using System.Net.Http.Headers;

class Program
{
    static void Main(string[] args)
    {
        Assignment a1 = new Assignment("Mike Whisozuki", "Fearmongering");
        Console.WriteLine(a1.GetSummary());

        MathAssignment a2 = new MathAssignment("Curious George", "Addition", "How to Add", "1-5");
        Console.WriteLine(a2.GetHomeworkList());

        WritingAssignment a3 = new WritingAssignment("Clifford Red", "Reading Rainbows", "How to be a Seeing Eye Dog");
        Console.WriteLine(a3.GetWritingInformation());
    }
} 

//List<Word> _tempWords = new List<Word>
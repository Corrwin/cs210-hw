using System;

public class ReflectingActivity : Activity{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();

    private Random rnd = new Random();   //I put this here because multiple methods need it. Same with the rng ints.
    private int rng1;
    private int rng2;

    public ReflectingActivity(){
        _name = "Reflecting";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
       _duration = 50;

        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");
        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");
    }

    private string GetRandomPrompt(){
        rng1 = rnd.Next(0, _prompts.Count());
        return _prompts[rng1];
    }

    public void DisplayPrompt(){
        Console.WriteLine(GetRandomPrompt());
    }

    private string GetRandomQuestion(){
        rng2 = rnd.Next(0, _questions.Count());
        return _questions[rng2];
    }

    public void DisplayQuestion(){
        Console.WriteLine(GetRandomQuestion());
    }

    
}
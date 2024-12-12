using System;

public class ListingActivity : Activity{
    int _count;
    public List<string> _prompts = new List<string>();

    public ListingActivity(int duration){
        _name = "Listing";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _duration = duration;
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");
    }

    //public void Run(){}
    
    public void GetRandomPrompt(){
        Random rnd = new Random();
        int rng = rnd.Next(0, 4);
        Console.WriteLine(_prompts[rng]);
    }

    public List<string> GetListFromUser(){
        return _prompts;
    }

}
using System;


public class ListingActivity : Activity{
    private int _count;
    private  List<string> _prompts = new List<string>();

    public ListingActivity(){
        _name = "Listing";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _duration = 50;
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");
    }

    public void Run(){
        Console.WriteLine(_name);
        Console.WriteLine(_description);
        Console.WriteLine("How long would you like to do the activity for?");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Prepare yourself...");
        Thread.Sleep(3000);

        Console.Clear();
                              //note that the 10 here could be easily made into another base var since every activity has a ThinkingTime
        GetRandomPrompt();
        Console.WriteLine("5...");
        Thread.Sleep(1000);
        Console.WriteLine("4...");
        Thread.Sleep(1000);
        Console.WriteLine("3...");
        Thread.Sleep(1000);
        Console.WriteLine("2...");
        Thread.Sleep(1000);
        Console.WriteLine("1...");
        Thread.Sleep(1000);
        Console.WriteLine("begin writing.");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        DateTime currentTime = DateTime.Now;
        while (currentTime < endTime){
            Console.ReadLine();
            _count++;
            currentTime = DateTime.Now;
        }
        Console.WriteLine($"You listed {_count} things!");
        _totalCount++;
        Thread.Sleep(1000);
        Console.WriteLine("Thank you for your participation!"); //this is the standard closing message            

        
    }
    
    public void GetRandomPrompt(){
        Random rnd = new Random();
        int rng = rnd.Next(0, 4);
        Console.WriteLine(_prompts[rng]);
    }

    public List<string> GetListFromUser(){
        return _prompts;
    }

}
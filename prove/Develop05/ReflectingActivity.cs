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

    public void Run(){
        Console.WriteLine("Let's do a " + _name +" activity!");
        Console.WriteLine(_description);
        Console.WriteLine("How long would you like to do the activity for?");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine("Prepare yourself...");
        Thread.Sleep(3000);

        Console.Clear();
        int _repeatInt = _duration/5;
        int _currentCount = 0;
        while (_currentCount < _repeatInt){
            DisplayPrompt();             //show question and prompt
            DisplayQuestion();

            int i = 0;                 
            while (i < 5){                      //again, this number could be replaced by another int called PauseTime
                Console.Write("-");
                Thread.Sleep(250);

                Console.Write("\b"); 
                Console.Write("/");              //do the animation loop
                Thread.Sleep(250);

                Console.Write("\b"); 
                Console.Write("|"); 
                Thread.Sleep(250);

                Console.Write("\b"); 
                Console.Write("\\"); 
                Thread.Sleep(250);

              Console.Write("\b"); 
                i++;
            }
            Console.Clear();
            _currentCount++;            
        }
        Console.WriteLine("Thank you for your participation!"); //this is the standard closing message
        _totalCount++;
        Thread.Sleep(2000);
        Console.WriteLine("You just completed a " + _name + $" activity that was {_duration} seconds long.");
        Thread.Sleep(2000);
    }
    
}
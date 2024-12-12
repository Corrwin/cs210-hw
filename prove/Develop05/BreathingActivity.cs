using System;

public class BreathingActivity : Activity{

    public  BreathingActivity(){
        _name = "Breathing";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
        _duration = 50;
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
                Console.WriteLine("Breathe in...");
                Console.Write("-");
                Thread.Sleep(250);

                Console.Write("\b"); 
                Console.Write("/");              
                Thread.Sleep(250);

                Console.Write("\b"); 
                Console.Write("|"); 
                Thread.Sleep(250);

                Console.Write("\b"); 
                Console.Write("\\"); 
                Thread.Sleep(250);

                Console.Write("\b");
                Console.Write("-");
                Thread.Sleep(250);

                Console.Write("\b"); 
                Console.Write("/");              
                Thread.Sleep(250);

                Console.Write("\b"); 
                Console.Write("|"); 
                Thread.Sleep(250);

                Console.Write("\b"); 
                Console.Write("\\"); 
                Thread.Sleep(250);

                Console.Write("\b"); 
                Console.Write("-");
                Thread.Sleep(250);

                Console.Write("\b"); 
                Console.Write("/");              
                Thread.Sleep(250);

                Console.Write("\b");
                Console.WriteLine("Breathe out...");
                Console.Write("|"); 
                Thread.Sleep(250);

                Console.Write("\b"); 
                Console.Write("\\"); 
                Thread.Sleep(250);

                Console.Write("\b");
                Console.Write("-");
                Thread.Sleep(250);

                Console.Write("\b"); 
                Console.Write("/");              
                Thread.Sleep(250);

                Console.Write("\b"); 
                Console.Write("|"); 
                Thread.Sleep(250);

                Console.Write("\b"); 
                Console.Write("\\"); 
                Thread.Sleep(250);

                Console.Write("\b"); 
                Console.Write("-");
                Thread.Sleep(250);

                Console.Write("\b"); 
                Console.Write("/");              
                Thread.Sleep(250);

                Console.Write("\b"); 
                Console.Write("|"); 
                Thread.Sleep(250);

                Console.Write("\b"); 
                Console.Write("\\"); 
                Thread.Sleep(250);

                Console.Write("\b");  
                _currentCount++;
        }
        Console.Clear();
         Console.WriteLine("Thank you for your participation!"); //this is the standard closing message
        Thread.Sleep(2000);
        Console.WriteLine("You just completed a " + _name + $" activity that was {_duration} seconds long.");
        Thread.Sleep(2000);
    }

}
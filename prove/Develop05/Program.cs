using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        BreathingActivity b1 = new BreathingActivity();
        ReflectingActivity r1 = new ReflectingActivity();
        ListingActivity l1 = new ListingActivity();
        int _totalCount = 0;

        while (_totalCount < 10){
            Console.WriteLine("Welcome to the Activity Hub! \nPlease choose an option: \n1. Start Breathing Activity \n2. Start Listing Activity \n3. Start Reflecting Activity \n4. Quit" );
            string userInput = Console.ReadLine();
            if (userInput == "1"){
                Console.Clear();
                b1.Run();
                _totalCount++;
            }
            else if  (userInput == "2"){
                Console.Clear();
                l1.Run();
                _totalCount++;
            }
            else if (userInput == "3"){
                Console.Clear();
                r1.Run();
                _totalCount++;
            } 
            else if (userInput == "4"){
                Console.WriteLine($"You completed a total of {_totalCount} activites this session!");
                break;
            }
            if (_totalCount == 10){Console.WriteLine("You have met your maximum activity alotment. Goodbye!");}
        }

    }

    
}
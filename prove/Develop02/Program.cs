using System;
using System.Runtime.InteropServices;

class Program
{ 
    static void Main(string[] args)
    {
        Journal NewJournal = new Journal;
        Console.WriteLine("Please select one of the following choices: \n 1. Write \n 2. Display \n 3. Load \n 4. Save \n 5. Quit");
        string userInput = Console.ReadLine();

        if (userInput == "1") {
            NewJournal.AddEntry();
        }
        else if (userInput == "2") {
            NewJournal.DisplayAll();
        }
        else if (userInput == "3") {
            Console.WriteLine('Please enter file name:');
            string LoadName = Console.ReadLine();
            NewJournal.LoadFromFile(LoadName);
        } 
        else if (userInput == "4") {
            Console.WriteLine('Please enter file name:');
            string SaveName = Console.ReadLine();
            NewJournal.SaveToFile(SaveName);
        }
        else if (userInput == "5") {
            Kill(); //turn off the program so it has to be ran again
        }
        else {
            Console.WriteLine("Invalid input, please try again.");
        }

        //I could not figure out how to make main run again at every loop
    } 
}   
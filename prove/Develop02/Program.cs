using System;

class Program
{ Journal NewJournal = new Journal;
    static void Main(string[] args)
    {
        Console.WriteLine("Please select one of the following choices: \n 1. Write \n 2. Display \n 3. Load \n 4. Save \n 5. Quit");

        if Console.ReadLine() = "1" {
            NewJournal.AddEntry();
        }
        else if Console.ReadLine() = "2" {
            NewJournal.DisplayAll();
        }
        else if Console.ReadLine() = "3" {
            Console.WriteLine('Please enter file name:');
            string LoadName = Console.ReadLine();
            NewJournal.LoadFromFile(LoadName);
        } 
        else if Console.ReadLine() = "4" {
            Console.WriteLine('Please enter file name:');
            string SaveName = Console.ReadLine();
            NewJournal.SaveToFile(SaveName);
        }
        else if Console.ReadLine() = "5" {
            Kill();
        }
        else {
            Console.WriteLine("Invalid input, please try again.");
        }

        //this is the only way I know of to repeat from the top. I know it's ineffective, but it will have to do.
        
    } 
}   
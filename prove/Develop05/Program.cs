using System;

class Program
{
    static void Main(string[] args)
    {
        ListingActivity l1 = new ListingActivity();
        ReflectingActivity r1 = new ReflectingActivity();
        r1.DisplayPrompt();
        r1.DisplayQuestion();

        int i = 0;
        while (i < 5){
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
            i++;

        }

    }
}
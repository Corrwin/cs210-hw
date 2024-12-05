using System;

class Program
{
    static void Main(string[] args)
    {
        /*    idk if I need to keep this but Justin Kase
         Console.Write("What is the magic number? ");
         int magicNumber = int.Parse(Console.ReadLine());  */
        
    
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int guess = -1;
        int guessCount = 0;

        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (magicNumber > guess)
                {Console.WriteLine("Higher");  guessCount = guessCount + 1;}
            else if (magicNumber < guess)
                {Console.WriteLine("Lower"); guessCount = guessCount + 1;}
            else
                {Console.WriteLine($"You guessed it in {guessCount} tries!");}
        }                    
    }
}
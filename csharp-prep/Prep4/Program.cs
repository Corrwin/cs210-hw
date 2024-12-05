using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        
        int inputNumber = -1;
        while (inputNumber != 0)
        {
            Console.Write("Enter a number (0 to quit): ");
            
            string inputResponse = Console.ReadLine();
            inputNumber = int.Parse(inputResponse);
            
            if (inputNumber != 0)
                {numbers.Add(inputNumber);}
        }

        // Part 1: Compute the sum
        int sum = 0;
        foreach (int number in numbers)
            {sum += number;}

        Console.WriteLine($"The sum is: {sum}");
//avg
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");
//max        
        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
                {max = number;}
        }
        Console.WriteLine($"The max is: {max}");
    }
}
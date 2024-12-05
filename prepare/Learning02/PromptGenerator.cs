using System;

public class PromptGenerator{
       List<string> _prompts = new List<string>();
    
//I know this is really ugly, but it works
    public string GetRandomPrompt() {
        _prompts.Add("Who was the most interesting person I interacted with today?");
        _prompts.Add("What was the best part of my day?");
        _prompts.Add("How did I see the hand of the Lord in my life today?");
        _prompts.Add("What was the strongest emotion I felt today?");
        _prompts.Add("If I had one thing I could do over today, what would it be?");
        //I could add more, but as long as the code works, this could be done ad infinitum


        //create random number based on list length
        Random randomGenerator = new Random();  
        int _rng = randomGenerator.Next(_prompts.Count);
        
        return _prompts[_rng];
    }
}
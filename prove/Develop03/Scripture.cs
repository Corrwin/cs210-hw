using System;

public class Scripture{
    public Reference _reference;
    public List<Word> _words = new List<Word>();

//constructors
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string[] words = text.Split(' ');      //first - split the text at every point there is a space.
        int i = 0;
        foreach (var word in words){
            Word _holdOver = new Word(word);  //second - for each new string, turn it into a word...
            _words.Add(_holdOver);            //...and then add it to the _words list!
        } 
    }


//methods
    public bool IsCompletelyHidden(){
        int i = 0;
        while (i < _words.Count()) {                 //this WHILE LOOP will repeat once for each Word in _word
             if (_words[i].isHidden() == false){     //if ANY Word of _words is NOT hidden...
                return false;
             }                                       //no need for an else statement
        }
        return true;                                 //if it doesn't return anything else, return as true
    }

    public string GetDisplayText(){
        string scripture = "";
        int i = 0;                          
        while (i <_words.Count()) {                                     //for each Word in _Words...
            scripture = scripture + " " + _words[i].GetDisplayText();   //...call GetDisplayText to get it as a string, then add that string to the others.
            i++;                                                        //I didn't add this at first, took so long to find it lol
        }
        return _reference.GetDisplayText() + "  " + scripture;                                               //finally, return the entire string, now a scripture.
        
    }
    public void HideRandomWords(int number){
        int i = 0;
        int killFactor = 0;
        Random rnd = new Random();
        while (i < number) {
            killFactor++;
            int rng = rnd.Next(0, _words.Count);                      //first, randomly choose an number within range of the length of _words
            if (_words[rng].isHidden() == false)                      //second, IF that Word in _words is NOT hidden...
            {                                                            
                _words[rng].Hide();                                    //...the hide it, and INCRIMENT the counter by one. 
                i++;                                                  //(KNOWN PROBLEM - if there are 2 unhidden words, and you tell it to hide 3, it will endlessly loop)
            }
            if (killFactor >= 1000){                                   //this enables ending the program when there's too few words left to hide
                Environment.Exit(0);
            }
            
        }
    }


} 


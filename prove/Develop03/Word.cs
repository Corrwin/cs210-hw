using System;

 public class Word{
    private string _text;
    private bool _isHidden;

    public Word(string text){
        _text = text;
        _isHidden = false;
    }

    public void Hide() {
        _isHidden = true;                       //method to set _isHidden to true
    }
    public void Show(){
        _isHidden = false;                       //method to set _isHidden to false
    }
    public bool isHidden(){                       //method to show what isHidden is
        return _isHidden;
    }
    public string GetDisplayText(){
        if (_isHidden == true) {                   //if _isHidden is somehow NULL, this means that it will default to showing that word
            return "____";
        }
        else return _text;
    }
 }
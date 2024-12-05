using System;

 public class Word{
    private string _text;
    private bool _isHidden;

    public Word(string text){
        _text = text;
        _isHidden = false;
    }

    public void Hide() {
        _isHidden = true;
    }
    public void Show(){
        _isHidden = false;
    }
    public bool isHidden(){
        return _isHidden;
    }
    public string GetDisplayText(){
        if (_isHidden == true) {                 //if _isHidden is somehow NULL, this means that it will default to showing that word
            return "____";
        }
        else return _text;
    }
 }
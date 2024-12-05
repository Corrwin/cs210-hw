using System;

public class Entry {
    string _date;
    string _promptText;
    string _entryText;

    public string Display() {
        return  _date + "\n :" + _promptText + "\n :" + _entryText;
    }
 
    public Entry (string date, string prompt, string text){
        _date = date;
        _promptText = prompt;
        _entryText = text;
    }   
}
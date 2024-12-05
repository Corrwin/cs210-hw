using System;
using System.ComponentModel.DataAnnotations;

public class Entry {
    string _date;
    string _promptText;
    string _entryText;

    public string Display() {
        return  _date + "\n" + _promptText + '\n' + _entryText;
    }
}
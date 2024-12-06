using System;

public class Comment {
    string _accountName;
    string _text;

    public Comment(accountName string, text string){
        _accountName = _accountName;
        _text = text;
    }

    public string DisplayComment(){
        return (_accountName + "\n" + _text);
    }

}
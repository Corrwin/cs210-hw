using System;
using System.Security.Cryptography.X509Certificates;

public class Comment {
    string _accountName;
    string _text;

    public Comment(string accountName, string text){
        _accountName = accountName;
        _text = text;
    }

    public string DisplayComment(){
        return (_accountName + "\n" + _text + "\n");
    }

}
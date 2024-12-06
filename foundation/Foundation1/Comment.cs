using System;
using System.Security.Cryptography.X509Certificates;

public class Comment {
    private string _accountName;
    private string _text;

    public Comment(string accountName, string text){
        _accountName = accountName;
        _text = text;
    }

    public string DisplayComment(){
        return (_accountName + " - " + _text + "\n");
    }

}
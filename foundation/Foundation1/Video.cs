using System;
using System.Diagnostics.Contracts;

public class Video{
    List<Comment> _comments = new List<Comment>();
    private string _title;
    private string _author;
    private int _secondLength;

    public Video(string title, string author, int secondLength) {
        _title = title;
        _author = author;
        _secondLength = secondLength;
    }

    public void AddComment(string commentName, string commentText){
        _comments.Add(new Comment(commentName, commentText));
    }

    public string DisplayAllInfo(){
        string allInfo = ($"Video Information \n Title: " + _title + "\nAuthor: " + _author + "\nLength: {_secondLength}" + "\n Comments: \n");

       int  i = 0;
        while (i < _comments.Count()){
            allInfo = allInfo + _comments[i].DisplayComment();
            i++;
        }
        return allInfo;
    }
}
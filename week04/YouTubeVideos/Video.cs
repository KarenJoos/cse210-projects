using System;
using System.Net;

public class Video
{
    public string _title;
    public string _author;
    public double _length;
    public List<Comment> _comments;

    // public Video(string title, string author, double length)
    // {
    //     _title = title;
    //     _author = author;
    //     _length = length;
    // }

    public string GetTitle()
    {
        string title = _title;

        return title;
    }
    public string GetAuthor()
    {
        string author = _author;
        return author;
    }
    public double GetLength()
    {
        double length = _length;
        return length;
    }
    public void SaveInListOfComments(Comment comment)
    {
        _comments.Add(comment);
    }
    public int GetNumberOfComments()
    {
        return _comments.Count();
    }
    public string DisplayListOfComments()
    {
        return string.Format(_comments.);
    }
}

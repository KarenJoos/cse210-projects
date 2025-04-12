using System;
using System.Security.Cryptography.X509Certificates;

public class Comment
{
    public string _name;

    public string _textofcomment;

    public Comment(string name, string comment)
    {
        _name = name;
        _textofcomment = comment;
    }

    public string GetDisplayComment()
    {
        string display = _name + _textofcomment;
        return display;
    }
}
using System;
using System.Security.Cryptography.X509Certificates;

public class Comment
{
    public string _name;

    public string _comment;

    public Comment(string name, string comment)
    {
        _name = name;
        _comment = comment;
    }

    public string GetDisplayComment()
    {
        string display = _name + _comment;
        return display;
    }
}
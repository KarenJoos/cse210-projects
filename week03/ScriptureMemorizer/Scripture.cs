using System;
using System.Globalization;
using System.IO;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private string _s1;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _s1 = text;
    }

    // public void HideRandomWords()
    // {
        // var random = new Random();
        // int index = random.Next(_words.count);
        // string randomWords = Word[index];

    //     return; 
    // }

    public string GetDisplayText()
    {
        _words = new List<Word>();
        _words = _s1.Split(' ').ToList();
        var text = String.Join("", _s1.ToArray());
        // string text = _words;
        Console.WriteLine(_reference.GetDisplayText());
        return text;
    }

    // public bool IsCompletelyHidden()
    // {
    //     Console.Clear();
    // }
}
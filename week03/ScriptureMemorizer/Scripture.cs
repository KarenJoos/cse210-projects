using System;
using System.Globalization;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string text = 
    }

    public void HideRandomWords()
    {
        var random = new Random();
        int index = random.Next(_words.count);
        string randomWords = Word[index];
    
        return;
    }

    public string GetDisplayText()
    {
        List<Word> _words = new List<Word>();
        var result = String.Join(", ", _words.ToArray());
        string text = _words;
    }

    public bool IsCompletelyHidden()
    {
        if 
    }
}
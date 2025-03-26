using System;

public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public void Display()
    {
        DateTime theCurrentTime = DateTime.Now;
        string DateText = theCurrentTime.ToShortDateString();
        string _date = DateText;

        Console.Write($"{_date} {_promptText}");
        Console.Write($"{_entryText}");
    }
}



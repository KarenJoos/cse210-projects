using System;
using System.ComponentModel;
using System.Security;
using System.IO;
using System.Reflection.Metadata.Ecma335;
using System.Collections.Generic;
using System.IO.Enumeration;
using System.Formats.Asn1;

public class Journal
{
    public List<Entry> _entries;

    // Add an entry
    public void AddEntry()
    {
        PromptGenerator pg = new PromptGenerator();
        string prompt = pg.GetRandomPrompt();

        Console.WriteLine($"{prompt}");
        Console.Write(">");

        string enter = Console.ReadLine();
        // Entry _entries = new Entry();

        List<Entry> _entries = new List<Entry>();
        _entries = new List<Entry>();
        _entries.Add(enter);
        
        Console.WriteLine("");

        // return _entries(); 
    }

    // Display all
    public void DisplayAll()
    {
        foreach (Entry e in _entries)
        {
            e.Display();
        }
    }

    // Save to file
    public void SaveToFile(string file)
    {
        Console.WriteLine("What is the filename? ");
        string fileName = Console.ReadLine();
        try
        {
            using (StreamWriter ouputFile = new StreamWriter(fileName))
            {
                foreach (Entry entry in _entries)
                {
                    
                }
            }
        }

    }

    // Load from a file

    public void LoadFromFile(string file)
    {
        string filename = "myFile.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string in lines)
        {
            string[] parts = lines.split("~|~");

            string date = parts[0];
            string prompt = parts[1];
            string entry = parts[2];
        }
    }
    
    
}
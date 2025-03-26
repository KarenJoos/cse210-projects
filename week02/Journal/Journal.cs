using System;
using System.ComponentModel;
using System.Security;
using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    // Add an entry
    public void AddEntry(Entry newEntry)
    {
        string anEntry = Console.ReadLine();
        Journal._entries.Add()
    }

    // Display all
    public void DisplayAll()
    {

    }

    // string filename = "myFile.txt";
    // string[] lines = System.IO.File.ReadAllLines(filename);
    // foreach (string in lines)
    // {
    //     string[] parts = line.Split("~|~");

    //     string date = parts[0];
    //     string promptText = parts[1];
    //     string entryText = parts[2];
    // }

    // Save to file
    public void SaveToFile()
    {

    }

    // Load from a file

    public void LoadFromFile()
    {
        
    }
}
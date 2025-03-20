using System;
using System.ComponentModel;
using System.Security;
using System.IO;

public class Journal
{

    // Add an entry


    // Display all
    string filename = "myFile.txt";
    string[] lines = System.IO.File.ReadAllLines(filename);
    foreach (string in lines)
    {
        string[] parts = line.Split("~|~");

        string date = parts[0];
        string promptText = parts[1];
        string entryText = parts[2];
    }

    // Save to file
    

    // Load from a file
}
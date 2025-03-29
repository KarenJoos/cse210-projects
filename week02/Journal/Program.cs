using System;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Globalization;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
    
        Console.WriteLine("Hello World! This is the Journal Project.");
        PromptUser();
    }

    public static void PromptUser()
    {
        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quite");
        Console.Write("What would you like to do? ");
        string number = Console.ReadLine();
        int userNumber = int.Parse(number);

        if (userNumber == 1)
        {
            Journal theJournal = new Journal();
            theJournal.AddEntry();
        }

        else if (userNumber == 2)
        {
            Journal theJournal = new Journal();
            theJournal.DisplayAll();
        }

        else if (userNumber == 3)
        {
            Journal theJournal = new Journal();
            theJournal.SaveToFile();
        }

        else if (userNumber == 4)
        {
            Journal theJournal = new Journal();
            theJournal.LoadFromFile();
        }

        else if (userNumber == 5)
        {
            Console.Write("Goodbye.");
            break;
        }

        else
        {
            Console.WriteLine("Invalid option, ");
        }

        PromptUser();
    }
}

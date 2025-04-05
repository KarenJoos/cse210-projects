using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");

        Reference r1 = new Reference("Doctorine & Covenants", 25, 12);
        Console.WriteLine(r1.GetDisplayText());
    }
}
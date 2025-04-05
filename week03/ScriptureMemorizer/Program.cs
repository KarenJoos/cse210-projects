using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");

        Reference r1 = new Reference("John", 3, 16);
        Console.WriteLine(r1.GetDisplayText());

        Scripture s1 = new Scripture(r1, "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasing life.");
        Console.WriteLine(s1.GetDisplayText());
        //Console.WriteLine(s1.IsCompletelyHidden());
    }
}
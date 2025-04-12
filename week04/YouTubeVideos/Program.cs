using System;

class Program
{
    static void Main(string[] args)
    {
        Video v1 = new Video();
        Console.WriteLine(v1.GetTitle());
        Console.WriteLine(v1.GetAuthor());
        Console.WriteLine(v1.GetLength());

        Comment c1 = new Comment("Smith", "Good Job");
        Console.WriteLine(c1.GetDisplayComment());

        Comment c2 = new Comment("George", "Nice");
    }
}
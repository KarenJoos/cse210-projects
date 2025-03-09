using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        PromptUserName();
        PromptUserNumber();

        SquareNumber(userNumber);
        DisplayResult(name, square);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Hello World!");
    }

    static void PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();

        // return userName;

    }

    static void PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        // return number;
    }

    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }

    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}.");
    }
}
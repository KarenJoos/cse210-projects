using System;

public class Menu
{
    private string _userInput;

    public string GetUserInput()
    {
        return _userInput;
    }

    public string UserSelection()
    {
        Console.WriteLine("Menu Options:");
        Console.WriteLine("1. Start breathing activity");
        Console.WriteLine("2. Start reflecting activity");
        Console.WriteLine("3. Start listing activity");
        Console.WriteLine("4. Quit");
        Console.Write("Select a choice from the menu: ");

        _userInput = Console.ReadLine();
        return _userInput;
    }

    public string MenuActivities();
    {
        UserSelection();
        if (_userInput == "1")
        {
            BreathingActivity breathingActivity = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.", 0);

            breathingActivity.Run();
            return "Breathing Activity";
        }


        else if (_userInput == "2")
{
    ReflectingActivity reflectingActivity = new ReflectingActivity("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", 0)
        }

else if (_userInput == "3")
{
            
        }
    }   

}
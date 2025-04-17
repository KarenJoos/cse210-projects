using System;

public class GoalManager
{
    private List<GoalManager> _goals;
    private int _score;
    private string _userInput;
    private string _goalType;

    public GoalManager(int score)
    {
        _score = score;
    }

    public string GetUserInput()
    {
        return _userInput;
    }

    public string UserSelection()
    {
        Console.WriteLine($"You have {_score}\n");
        Console.WriteLine("\nMenu Options:");
        Console.WriteLine("1. Create New Goal");
        Console.WriteLine("2. List Goals");
        Console.WriteLine("3. Save Goals");
        Console.WriteLine("4. Load Goals");
        Console.WriteLine("5. Record Goals");
        Console.WriteLine("6. Quit");
        Console.Write("Select a choice from the menu: ");

        _userInput = Console.ReadLine();

        return _userInput;
    }

    // This is the main function for this class. It is called by Program.cs, and then runs the menu loop.
    public void Start()
    {
        UserSelection();

        if (_userInput == "1")
        {
            Console.WriteLine("The types of Goals are:");
            Console.WriteLine("1. Simple Goal");
            Console.WriteLine("2. Eternal Goal");
            Console.WriteLine("3. Checklist Goal");
            Console.Write("What type of goal would you like to create? ");

            // _goalType = Console.ReadLine();

            // return _goalType;

            // SimpleGoal simpleGoal = new SimpleGoal("Simple Goals", "", 0);
            // simpleGoal.Run();
            // return "Simple Goals";
        }

        else if (_userInput == "2")
        {
            // ListGoal listGoal = new ListGoal("List Goals", "", 0);
            // listGoal.Run();
            // return "List Goals";
        }

        else if (_userInput == "3")
        {
            // SaveGoal saveGoal = new SaveGoal("Save Goals", "", 0);
            // saveGoal.Run();
            // return "Save Goals";
        }

        else if (_userInput == "4")
        {
            // SaveGoal saveGoal = new SaveGoal("Load Goals", "", 0);
            // saveGoal.Run();
            // return "Save Goals";
        }

        else if (_userInput == "5")
        {
            // SaveGoal saveGoal = new SaveGoal("Save Goal", "", 0);
            // saveGoal.Run();
            // return "Save Goal";
        }

        else if (_userInput == "6")
        {
            Console.WriteLine("Exiting the program. Thanks for participating!");
            return;
            
        }

        else
        {
            Console.WriteLine("Invalid selection. Please try again.");
        }

    }


    // Displays the players current score.
    public void DisplayPlayerInfo()
    {
        _score = 0;
        _score++;
        Console.WriteLine($"You have {_score} points");
    }

    // Lists the names of each of the goals.
    public void ListGoalNames()
    {
        Console.
    }

    // Lists the details of each goal (including the checkbox of whether it is complete).
    public void ListGoalDetails()
    {

    }

    // Asks the user for the information about a new goal. Then, creates the goal and adds it to the list.
    public void CreateGoal()
    {

    }

    // Asks the user which goal they have done and then records the event by calling the RecordEvent method on that goal.  
    public void RecordEvent()
    {

    }

    // Asks the user which goal they have done and then records the event by calling the RecordEvent method on that goal.
    public void SaveGoals()
    {

    }

    // Loads the list of goals from a file.
    public void LoadGoals()
    {

    }
}
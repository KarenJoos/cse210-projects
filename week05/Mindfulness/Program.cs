using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Mindfulness Project.");
    }
}

// Mindfulness activity
// Program.cs
// using System;
// using System.Diagnostics;
 
// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Hello World! This is the Mindfulness Project.");
//         Menu menu = new Menu();
//         string activity = menu.MenuActivities();
//     }
// }

// Menu.cs
// public class Menu
// {
//     private string _userInput;

//     public string GetUserInput()
//     {
//         return _userInput;
//     }

//     public string UserSelection()
//     {
//         Console.WriteLine("Menu Options:");
//         Console.WriteLine("1. Beathing Activity");
//         Console.WriteLine("2. Reflection Activity");
//         Console.WriteLine("3. Listing Activity");
//         Console.WriteLine("4. Exit");
//         Console.Write("Please select an option: ");

//         _userInput = Console.ReadLine();
//         return _userInput;
//     }

//     public string MenuActivities()
//     {
//         UserSelection();
//         if (_userInput == "1")
//         {
//             BreathingActivity breathingActivity = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.", 0);
//             breathingActivity.Run();
//             return "Breathing Activity";
//         }
//         else if (_userInput == "2")
//         {
//             ReflectingActivity reflectingActivity = new ReflectingActivity("Reflecting Activity", "This activity will help you reflect on your thoughts and feelings. Take a moment to think about something meaningful to you.", 0);
//             reflectingActivity.Run();
//             return "Reflecting Activity";
//         }
//         else if (_userInput == "3")
//         {
//             ListingActivity listingActivity = new ListingActivity("Listing Activity", "This activity will help you list things that you are grateful for. Take a moment to think about the things that bring you joy.", 0);
//             listingActivity.Run();
//             return "Listing Activity";
//         }
//         else if (_userInput == "4")
//         {
//             Console.WriteLine("Exiting the program. Thanks for participating!");
//             return "Exit";
//         }
//         else
//         {
//             return "Invalid selection. Please try again.";
//         }
//     }
// }

// Activity.cs


// public class Activity
// {
//     private string _activityName;
//     private string _activityDescription;
//     private int _activityDuration;

//     private static int _activityCount = 0;

//     public Activity(string activityName, string activityDescription, int activityDuration)
//     {
//         _activityName = activityName;
//         _activityDescription = activityDescription;
//         _activityDuration = activityDuration;
//     }

//     public void DisplayStartingMessage()
//     {
//         _activityCount++;

//         Console.WriteLine($"Welcome to the {_activityName}!\n");
//         Console.WriteLine($"{_activityDescription}\n");
//         Console.Write("How many seconds would you like to do this activity for? ");
//         int duration = int.Parse(Console.ReadLine());
//         _activityDuration = duration;
//         Console.WriteLine($"\nThis activity will last for {_activityDuration} seconds.\n");
//         ShowSpinner(3);
//     }

//     public void DisplayEndingMessage()
//     {
//         Console.WriteLine($"\nCongratulations!");
//         Thread.Sleep(5000);
//         Console.WriteLine($"You have completed {_activityDuration} seconds of the {_activityName}.\n");
//         Console.WriteLine($"\nTotal number of activities done so far: {_activityCount}");
//         ShowSpinner(3);
//         Menu menu = new Menu();
//         menu.MenuActivities();


//     }

//     public void ShowSpinner(int seconds)
//     {
//         DateTime startTime = DateTime.Now;
//         DateTime endTime = startTime.AddSeconds(seconds);
//         string[] spinner = { "|", "/", "-", "\\" };
//         int index = 0;

//         while (DateTime.Now < endTime)
//         {
//             Console.Write(spinner[index]);
//             Console.Write("\b");
//             index = (index + 1) % spinner.Length;
//             Thread.Sleep(500);
//         }
//     }

//     public void ShowCountDown(int seconds)
//     {
//         for (int i = seconds; i > 0; i--)
//         {
//             Console.Write(i + "\b");
//             Thread.Sleep(1000);
//         }
//         Console.WriteLine();
//     }

//     public void SetDuration(int duration)
//     {
//         _activityDuration = duration;
//     }

//     public int GetDuration()
//     {
//         return _activityDuration;
//     }
// }

// BreathingActivity.cs
// public class BreathingActivity : Activity
// {
//     public BreathingActivity(string activityName, string activityDescription, int activityDuration) : base(activityName, activityDescription, activityDuration)
//     {

//     }

//     public void Run()
//     {
//         DisplayStartingMessage();
//         int breath = GetDuration();

//         Console.WriteLine("Get ready to breathe in and out.");
//         ShowSpinner(3);

//         while (breath > 0)
//         {
//             Console.Clear();
//             BreatheInAnimation();
//             ShowCountDown(3);

//             Console.Clear();
//             BreatheOutAnimation();
//             ShowCountDown(5);

//             breath -= 8;
//         }

//         ShowSpinner(3);
//         DisplayEndingMessage();
//     }

//     private void BreatheInAnimation()
//     {
//         int maxSpaces = 10;

//         for (int i = 0; i <= maxSpaces; i++)
//         {
//             Console.SetCursorPosition(0, 0);
//             Console.Write(new string(' ', i));
//             Console.Write("Breathe in...");
//             Thread.Sleep(150);
//         }
//     }

//     private void BreatheOutAnimation()
//     {
//         int maxSpaces = 10;

//         for (int i = maxSpaces; i >= 0; i--)
//         {
//             Console.SetCursorPosition(0, 0);
//             Console.Write(new string(' ', i));
//             Console.Write("Breathe out...");
//             Thread.Sleep(200);
//         }
//     }
// }


// ReflectingActivity.cs
// public class ReflectingActivity : Activity
// {
//     private List<string> _prompts = new List<string>
//     {
//         "Think of a time when you stood up for someone else.",
//         "Think of a time when you did something really difficult.",
//         "Think of a time when you helped someone in need.",
//         "Think of a time when you made a difference in someone's life."
//     };
//     private List<string> _questions = new List<string>
//     {
//         "Why was this experience meaningful to you?",
//         "Have you ever done anything like this before?",
//         "How did you get started?",
//         "How did you feel when it was happening?",
//         "What was the outcome of the event?",
//         "What did you learn about yourself through this experience?",
//         "How did you feel when it was complete?",
//         "What did you learn from this experience?",
//         "What would you do differently if you could do it again?"
//     };

//     public ReflectingActivity(string activityName, string activityDescription, int activityDuration) : base(activityName, activityDescription, activityDuration)
//     {

//     }

//     public void Run()
//     {
//         DisplayStartingMessage();
//         int duration = GetDuration();
//         Console.WriteLine("Get ready to reflect on a prompt.");
//         ShowSpinner(3);
//         Random random = new Random();
//         int randomPromptIndex = random.Next(_prompts.Count);
//         string prompt = _prompts[randomPromptIndex];
//         Console.WriteLine($"\n--- Prompt ---\n{prompt}\n");
//         Console.WriteLine("When you are ready press enter to continue\n");
//         Console.ReadLine();
//         ShowSpinner(5);
//         Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.\n");

//         int questionDuration = 10;
//         int maxQuestions = duration / questionDuration;

//         for (int i = 0; i < maxQuestions; i++)
//         {
//             Console.WriteLine(_questions[i]);
//             ShowSpinner(questionDuration);
//             duration -= questionDuration;
//             Console.WriteLine();
//         }

//         ShowSpinner(3);
//         DisplayEndingMessage();
//     }

//     public string GetRandomPrompt()
//     {
//         Random random = new Random();
//         int randomIndex = random.Next(_prompts.Count);
//         return _prompts[randomIndex];
//     }

//     public string GetRandomQuestion()
//     {
//         Random random = new Random();
//         int randomIndex = random.Next(_questions.Count);
//         return _questions[randomIndex];
//     }

//     public void DisplayPrompt()
//     {
//         Console.WriteLine($"Prompt: {GetRandomPrompt()}");
//     }

//     public void DisplayQuestions()
//     {
//         Console.WriteLine($"Question: {GetRandomQuestion()}");
//     }
// }

// ListingActivity.cs
// public class ListingActivity : Activity
// {
//     private List<string> _prompts = new List<string>
//     {
//         "Who are people that you appreciate?",
//         "What are personal strengths of yours?",
//         "Who is someone that you have helped this week?",
//         "When have you felt the Holy Ghost this month?",
//         "What are some things you are grateful for today?",
//         "Who are some of your personal heroes?"
//     };

//     public ListingActivity(string activityName, string activityDescription, int activityDuration) : base(activityName, activityDescription, activityDuration)
//     {

//     }

//     public void Run()
//     {
//         DisplayStartingMessage();
//         int duration = GetDuration();
//         Console.WriteLine("Get ready to list your thoughts.");
//         ShowSpinner(3);
//         Random random = new Random();
//         int randomPromptIndex = random.Next(_prompts.Count);
//         string prompt = _prompts[randomPromptIndex];
//         Console.WriteLine($"\n--- Prompt ---\n{prompt}\n");
//         ShowCountDown(5);
//         Console.WriteLine($"List as many items as you can in {duration} seconds.\n");
//         DateTime startTime = DateTime.Now;
//         int itemCount = 0;
//         while ((DateTime.Now - startTime).TotalSeconds < duration)
//         {
//             Console.Write($"> ");
//             string userInput = Console.ReadLine();

//             if (!string.IsNullOrEmpty(userInput))
//             {
//                 itemCount++;
//             }
//         }
//         Console.WriteLine($"\nTime's up! You listed {itemCount} items.");

//         ShowSpinner(3);
//         DisplayEndingMessage();
//     }
// }

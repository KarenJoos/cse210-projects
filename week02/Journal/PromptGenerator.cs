using System;
using System.Security.Cryptography;

public class Prompts
{
    // public List<Prompts> _promptText = new List<Prompts>();

    public readonly string[] _promptText = {
        "What was your most interesting interaction today?",
        "What about your day did you enjoy the most?",
        "In which ways did you see the Lord's hand in your life today?",
        "If you could do one thing over today what would it be?",
        "What are three things you are grateful for today?",
        "What is one way you can be kinder to yourself about today?",
        "What can you make a priority for your goals?",
        "What is one of your strengths and how do you use it?"
    };

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_promptText.length);

        return _promptText[index];
    }

    

}
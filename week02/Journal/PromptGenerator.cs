using System;
using System.Security.Cryptography;
using System.Collections.Generic;

public class PromptGenerator
{
    public List<string> _prompts;
    public static string returnPrompt;
    public string GetRandomPrompt()
    {

        _prompts = new List<string>()
        {
            "What was your most interesting interaction today?",
            "What about your day did you enjoy the most?",
            "In which ways did you see the Lord's hand in your life today?",
            "If you could do one thing over today what would it be?",
            "What are three things you are grateful for today?",
            "What is one way you can be kinder to yourself about today?",
            "What can you make a priority for your goals?",
            "What is one of your strengths and how do you use it?"
        };
        Random r = new Random();
        int randomIndex = r.Next(_prompts.Count);
        returnPrompt = _prompts[randomIndex];

        return returnPrompt.ToString();
    }


    

}
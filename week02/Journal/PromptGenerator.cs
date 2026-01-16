using System;
using System.Collections.Generic;

public class PromptGenerator
{
    // I created a list of prompts and used the Random class to select a random prompt from the list.
    // I added prompts that would encourage reflection and introspection.
    public List<string> _prompts = new List<string>()
    {
        "What was the best part of your day?",
        "Who was the most interesting person I interacted with today?",
        "How did I see the hand of the Lord in my life today?",
        "What are you grateful for today?",
        "If I had one thing I could do over today, what would it be?",
        "What was one thing I learned today?",
        "What was a challenge I faced today and how did I overcome it?"

    };
    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}
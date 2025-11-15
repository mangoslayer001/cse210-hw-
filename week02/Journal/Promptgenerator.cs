using System;
using System.Collections.Generic;

public class PromptGenerator
{
    private readonly List<string> _prompts = new()
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        // Add your own extras
        "What is one small win I had today?",
        "What is something I learned today?"
    };

    private readonly Random _rand = new();

    public string GetRandomPrompt()
    {
        return _prompts[_rand.Next(_prompts.Count)];
    }
}

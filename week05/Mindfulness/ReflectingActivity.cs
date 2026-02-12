using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    List<string> _prompt = new List<string>();
    List<string> _questions = new List<string>();

    public ReflectingActivity() : base(
            "Reflection",
            "This activity will help you reflect on times in your life when you have shown strength and resilience. " +
            "This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
        _prompt.Add("Think of a time when you stood up for someone else");
        _prompt.Add("Think of a time when you helped someone in need.");
        _prompt.Add("Think of a time when you did something really  difficult.");
        _prompt.Add("Think of a time when you felt proud of yourself.");
        _prompt.Add("Think of a time when you did something truly selfless.");


        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("What did you learn from this experience?");
        _questions.Add("How did you feel during this experience?");
        _questions.Add("How can you apply this lesson in your life?");
        _questions.Add("What made this experience different?");
        _questions.Add("Why do you remember this experience?");


    }
    public void Run() 
    {
        
        DisplayStartingMessage();

        int duration = GetDuration();
        DateTime end = DateTime.Now.AddSeconds(duration);

        
        DisplayPrompt();
        Console.WriteLine("When you have something in mind, press Enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions:");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();

        
        while (DateTime.Now < end)
        {
            DisplayQuestions();
            ShowSpinner(6);  
            Console.WriteLine();
        }

        DisplayEndingMessage();

        
    }
    public string GetRandomPrompt()
    {
        
        Random rand = new Random();
        return _prompt[rand.Next(_prompt.Count)];

    }
    public string GetRandomQuestion()
    {
        
        Random rand = new Random();
        return _questions[rand.Next(_questions.Count)];

    }
    public void DisplayPrompt()
    {
        
        string prompt = GetRandomPrompt();
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine($"--- {prompt} ---");
        Console.WriteLine();

    }
    public void DisplayQuestions()
    {
        
        string question = GetRandomQuestion();
        Console.Write($"> {question} ");

    }

}
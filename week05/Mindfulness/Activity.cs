using System;
using System.Threading;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
        
    }
    public void DisplayStartingMessage()
    {
        
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity");
        Console.WriteLine(_description);
        Console.WriteLine();
        
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.Write("Get ready... ");
        ShowSpinner(3);
        Console.WriteLine();

    }
    public void DisplayEndingMessage()
    {
        
        Console.WriteLine();
        Console.WriteLine("Well done!!");
        ShowSpinner(4);

        Console.WriteLine();
        Console.WriteLine($"You have completed {_duration} seconds of the {_name} Activity.");
        ShowSpinner(4);
        Console.WriteLine();

        
    }
    public void ShowSpinner(int seconds)
    {
        
        string[] symbols = { "|", "/", "-", "\\" };
        DateTime end = DateTime.Now.AddSeconds(seconds);
        int i = 0;

        while (DateTime.Now < end)
        {
            Console.Write(symbols[i % symbols.Length]);
            Thread.Sleep(250);
            Console.Write('\b'); 
            i++;
        }

    }
    public void ShowCountDown(int seconds)
    {
        
       
        for (int i = seconds; i > 0; i--)
            {
                Console.Write(i + " ");
                Thread.Sleep(1000);
            }
            Console.WriteLine();  
    }
    public int GetDuration()
    {
        return _duration;
    }
}
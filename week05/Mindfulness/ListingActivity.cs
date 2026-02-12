using System;

public class ListingActivity : Activity
{
    private int _count;
    List<string> _prompts = new List<string>();
    private Random _rand = new Random();

    public ListingActivity() : base(
        "Listing",
        "This activity will help you reflect on the good things in your life by listing as many items as you can in a topic.")

    {
        _prompts.Add("Who are people that you appreciate? ");
        _prompts.Add("What are personal strengths of yours? ");
        _prompts.Add("Who are people that you have helped this week? ");
        _prompts.Add("When have you felt the Holy Ghost this month? ");
        _prompts.Add("Who are some of your personal heroes? ");
        
    }
    public void Run()
    {
        
        
        DisplayStartingMessage();

        int duration = GetDuration();
        DateTime end = DateTime.Now.AddSeconds(duration);

        Console.WriteLine("List as many responses as you can to the following prompt:");
        GetRandomPrompt();
        
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();        
        
        _count = 0;
        GetListFromUsers(); 
        Console.WriteLine();
        Console.WriteLine($"You listed {_count} item(s).");

        DisplayEndingMessage();
    }
    public void GetRandomPrompt()
    {
        
        string prompt = _prompts[_rand.Next(_prompts.Count)];
        Console.WriteLine($"--- {prompt} ---");

    }
    public List<string> GetListFromUsers()
    {
        
        DateTime end = DateTime.Now.AddSeconds(GetDuration());

        Console.WriteLine("Start listing! (Press Enter after each item)");
        Console.WriteLine();

        while (DateTime.Now < end)
        {
            Console.Write("> ");
            if (DateTime.Now >= end) break;

            string entry = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(entry))
            {
                _count ++;

            }
        }
        return _prompts;


    }

}
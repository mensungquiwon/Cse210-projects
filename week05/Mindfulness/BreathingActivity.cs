using System;
using System.IO.Compression;

public class BreathingActivity : Activity
{

        
    public BreathingActivity() : base(
        "Breathing",
        "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
        

    }

    
    public void Run()
    {
        
        DisplayStartingMessage();

        int duration = GetDuration();
        DateTime end = DateTime.Now.AddSeconds(duration);

        while (DateTime.Now < end)
        {
            Console.Write("Breathe in... ");
            ShowCountDown(5); // Inhale for 4 seconds

            if (DateTime.Now >= end) break;

            Console.Write("Breathe out... ");
            ShowCountDown(5); // Exhale for 6 seconds

        
            Console.WriteLine();
        }

        DisplayEndingMessage();
    }

}
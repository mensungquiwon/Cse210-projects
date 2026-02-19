using System;
using System.Collections.Generic;
using System.Globalization; // needed for ParseExact

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine();
        

    
        List<Activity> activities = new List<Activity>();

    
        Activity activity  = new Running("03 Nov 2022", 30, 3.0);   // 3.0 miles in 30 min

        activities.Add(activity);
    
    
        foreach (Activity a in activities)
        {
            
            Console.WriteLine(a.GetSummary());
        }
        Console.WriteLine();
    } 
}
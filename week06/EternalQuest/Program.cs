using System;
using EternalQuest;

class Program
{
    static void Main(string[] args)
    {
        // Added conditionings to validate user input and prevent crashes.
        Console.WriteLine("Welcome to Eternal Quest!");
        GoalManager manager = new GoalManager();

        while (true)
        {
            Console.WriteLine();
            manager.DisplayPlayerInfo();
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Create New Goal");
            Console.WriteLine(" 2. List Goals");
            Console.WriteLine(" 3. Record Event");
            Console.WriteLine(" 4. Save Goals");
            Console.WriteLine(" 5. Load Goals");
            Console.WriteLine(" 6. Quit");
            Console.Write("Select a choice from the menu: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    manager.CreateGoal();
                    break;

                case "2":
                    manager.ListGoalDetails();
                    break;

                case "3":
                    manager.RecordEvent();
                    break;

                case "4":
                    manager.SaveGoals();
                    break;

                case "5":
                    manager.LoadGoals();
                    break;

                case "6":
                    Console.WriteLine("Goodbye!");
                    return;

                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }
        }
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        
        bool running = true;

        while (running)
        {
            Console.Clear();
            Console.WriteLine("Hi, what you want to do today?");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflecting Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");

            string choice = Console.ReadLine();
            
            switch (choice)
            {
                case "1":
                    BreathingActivity breath = new BreathingActivity();
                    breath.Run();
                    break;

                case "2":
                    ReflectingActivity reflect = new ReflectingActivity();
                    reflect.Run();
                    break;

                case "3":
                    ListingActivity listing = new ListingActivity();
                    listing.Run();          
                    break;

                case "4":
                    Console.WriteLine("Goodbye, See You Tomorrow!");
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid choice. Press Enter to continue...");
                    Console.ReadLine();
                    break;
            }
        }



    }
}
using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        string menuChoice = "";
        Journal myJournal = new Journal();
        while (menuChoice != "5")
        {
            Console.WriteLine("Welcome to the Journal program!");
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write ");
            Console.WriteLine("2. Load ");
            Console.WriteLine("3. Save ");
            Console.WriteLine("4. Display ");
            Console.WriteLine("5. Quit");
            Console.Write("what would you like to do? ");
            menuChoice = Console.ReadLine();
            Console.WriteLine();

            if (menuChoice == "1")
            {
            
            PromptGenerator promptGenerator = new PromptGenerator();
            Entry entry = new Entry();
            entry._date = "2024-06-10";
            entry._promptText = promptGenerator.GetRandomPrompt();
            Console.WriteLine(entry._promptText);
            entry._entryText = Console.ReadLine();
            Console.WriteLine();
            myJournal._entries.Add(entry);
            }
            else if (menuChoice == "2")
            {
                Console.Write("Enter the filename to load: ");
                string filename = Console.ReadLine();
                myJournal.LoadFromFile(filename);

                if (filename == "")
                {
                    Console.WriteLine("No file name entered. Please try again.");
                }
            }
            else if (menuChoice == "3")
            {
                Console.Write("Enter the filename to save: ");
                string filename = Console.ReadLine();
                myJournal.SaveToFile(filename);
            
            }
            else if (menuChoice == "4")
            {
                myJournal.DisplayAll();
            }
            else
            {
                Console.WriteLine("Goodbye!");
            }
        }
    }
}

            

            


        
            
                         
            
    
using System;

class Program
{
    static void Main(string[] args)
    {
        // Ask user for their name and greet them
        Console.WriteLine("Hello World! This is the Exercise1 Project.");

        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();
        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine(); 

        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");  

    }
}
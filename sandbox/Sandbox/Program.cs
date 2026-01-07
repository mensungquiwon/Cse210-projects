using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World!!!");
        Console.WriteLine("This is a C# program.");

        int number = 34;
        number = number + 6;
        Console.WriteLine("The result is: " + number);

        Console.Write("what is your name? ");
        string name = Console.ReadLine();
        Console.Write($"Your name is {name}.");

    }
}
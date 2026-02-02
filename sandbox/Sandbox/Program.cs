using System;
using System.ComponentModel;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World!!!");
        // Console.WriteLine("This is a C# program.");

        // int number = 34;
        // number = number + 6;
        // Console.WriteLine("The result is: " + number);


 

        // using conditionals
        // // Console.Write("what is your name? ");
        // string name = Console.ReadLine();
        // if (name == "Jonathan")
        // {
        //    Console.Write($"Your name is {name}.");
        // }
        // else
        // {
        //     Console.Write($"Sorry! {name} I would like to meet Jonathan.");
        // }

        // string bname = "";
        // if (!(bname == "Jonathan" || bname == "James" || bname == "John"))
        // {
        //     Console.WriteLine("This is not one of those three");
        // }
        // string valueInText = "42";
        // int number = int.Parse(valueInText);
        // number += 8;
        // Console.WriteLine($"The number is {number}.");

        // converting string to integer
        // Console.Write("What is your favorite number? ");
        // string userInput = Console.ReadLine();
        // int favoriteNumber = int.Parse(userInput);
        // Console.WriteLine($"Your favorite number is {favoriteNumber}.");
        
        // int bNumber = 42;
        // string txtVersion = bNumber.ToString();
        // Console.WriteLine($"The string version of the number is {txtVersion}.");


        // Console.Write("Enter number; ");
        // string valueFromUser = Console.ReadLine();
        // int x = int.Parse(valueFromUser);
        // int y = 2;

        // if (x > y)
        // {
        //     Console.WriteLine($"{x} is greater than {y}.");
        // }
        // else if (x < y)
        // {
        //     Console.WriteLine($"{x} is less than {y}.");
        // }
        // else
        // {
        //     Console.WriteLine($"{x} is equal to {y}.");
        // }

        // string response = "yes";
        // while (response == "yes")
        // {
        //     Console.Write("Do you want to continue? ");
        //     response = Console.ReadLine();
        // }

        // string comment;
        // do
        // {
        //     Console.Write("Do you like programming? ");
        //     comment = Console.ReadLine();

        // } while (comment == "yes");

        // for (int i = 2; i < 20; i = i + 2)
        // {
        //     Console.WriteLine($"The value of i is: {i}");
        // }

        // Random randomGenerator = new Random();
        // int number = randomGenerator.Next(1, 11);
        // Console.WriteLine($"The random number is: {number}");


        List<int> numbers = new List<int>();
        List<string> words = new List<string>();
        words.Add("Phone");
        words.Add("Keyboard");
        words.Add("Mouse");

        // foreach (string word in words)
        // {
        //     Console.WriteLine(word);
        // }
        // for (int i = 0; i < words.Count; i++)
        // {
        //     Console.WriteLine(words[i]);
        // Console.WriteLine($"There are {words.Count} words in the list.");


        // function examples
        void DisplayMessage()
        {
            Console.WriteLine("This is a message from a function.");
        }
        DisplayMessage();

        static void Message()
        {
            Console.WriteLine("This is a static message from a static function.");
        }
        static void PersonalMessage(string userName)
        {
            Console.
            Console.WriteLine($"Hello, {userName}! Welcome to the program.");
        }
        static int AddNumbers(int first, int second)
        {
            int sum = first + second;
            return sum;


    }
}
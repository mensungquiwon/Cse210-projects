using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);
        int guess = 0;

        while (guess != magicNumber)
        {
        Console.Write("What is your guess? ");
        string userGuess = Console.ReadLine();
        guess = int.Parse(userGuess);
            if (guess < magicNumber)
            {
                Console.WriteLine(" lower!");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("higher!");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }

        

    }


}



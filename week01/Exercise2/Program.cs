using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage?  ");
        string gradeInput = Console.ReadLine();
        int gradePercentage = int.Parse(gradeInput);
        string letter = "";

        if (gradePercentage >= 90)
        {
            letter = "A";
        }
        else if (gradePercentage >= 80)
        {
            Console.WriteLine(letter = "B");
        }
        else if (gradePercentage >= 70)
        {
            Console.WriteLine(letter = "C");
        }
        else if (gradePercentage >= 60)
        {
            Console.WriteLine(letter = "D");
        }
        else  
        {
            Console.WriteLine(letter = "F");
        }
        Console.WriteLine($"Your  grade is: {letter}");

            if (gradePercentage >= 70)
            {
                Console.WriteLine("Congratulations! You passed the course.");
            }
            else
            {
                Console.WriteLine("Better luck next time!");
            }

    }
}
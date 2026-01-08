using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int number = -1;
        while (number != 0)
        {
            Console.Write("Enter a number, (type 0 to quit): ");
            string userNumber = Console.ReadLine();
            number = int.Parse(userNumber);
            if (number != 0)
            {
                numbers.Add(number);
            }
        
        } 
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }
        Console.WriteLine($"The sum of the numbers you entered is: {sum}");
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int max = numbers[0];
        int min = numbers[0]; // A large number
        foreach (int num in numbers)
        {
            if (num > max)
            {
                max = num;
            }
            if (num < min)
            {
                min = num;
            }
        }
        Console.WriteLine($"The minimum number is: {min}");
        Console.WriteLine($"The maximum number is: {max}");
    }  
    

}
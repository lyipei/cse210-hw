using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage?");
        string answer = Console.ReadLine();
        int number = int.Parse(answer);

        string letter = "";

        if (number >= 90)
        {
            letter = "A";
        }
        else if (number >= 80)
        {
            letter = "B";
        }
        else if (number >= 70)
        {
            letter = "C";
        }
        else if (number >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        
        Console.WriteLine($"Your grade is {letter}.");

        if (number >= 70)
        {
            Console.WriteLine("You have passed the course!");
        }
        else
        {
            Console.WriteLine("Don't worry, keep working hard for next time!");
        }
    }
}
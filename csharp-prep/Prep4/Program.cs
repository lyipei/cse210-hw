using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        List <int> numbers = new List<int> ();

        int useNum = -1;
        while (useNum != 0 )
        {
            Console.WriteLine("Enter a number (0 to quit):");

            string useRes = Console.ReadLine();
            useNum = int. Parse(useRes);

            if (useNum != 0)
            {
                numbers.Add(useNum);
            }
        }

        // part1 sum 
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");

        // part2 average
        float average = ((float)sum) / numbers.Count;
        Console. WriteLine($"The average is: {average}.");

        // part3 max 
        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The max is: {max}.");
    }
}
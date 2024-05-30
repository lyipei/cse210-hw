using System;
using System.ComponentModel;
using System.Diagnostics;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Scripture Memorization Program!");
        Console.WriteLine("Enter the number of words you want to hide:");
        Console.WriteLine();

        Scripture scripture = new Scripture(new Reference("Alma 32 15-16"),
            "15 For behold, my brethren, it is given unto you to judge, that ye may know good from evil; and the way to judge is as plain, that ye may know with a perfect knowledge, as the daylight is from the dark night.\n"+
            "16 For behold, the Spirit of Christ is given to every man, that he may know good from evil; wherefore, I show unto you the way to judge; for every thing which inviteth to do good, and to persuade to believe in Christ, is sent forth by the power and gift of Christ; wherefore ye may know with a perfect knowledge it is of God."
        );

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.Write("\nEnter the number of words to hide (or type 'quit' to exit): ");
            /*Console.WriteLine("\nPress Enter to hide more words or type 'quit' to exit.");*/
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            if (!int.TryParse(input, out int wordsToHide))
            {
                Console.WriteLine("Invalid input. Please enter a valid number or 'quit' to exit");
                Console.ReadLine();
                continue;
            }

            scripture.HideRandomWords(wordsToHide);
            if (scripture.AllWordsHidden())
            {
                Console.WriteLine("All words hidden. Press Enter to reveal, or type 'quit' to exit.");
                input = Console.ReadLine();

                if (input.ToLower() == "quit")
                break;

                Console.Clear();
                continue;
            }
    

        }
        Console.WriteLine("Thank you for using the Scripture Memorization Program!");
    }

    private string GetDebuggerDisplay()
    {
        return ToString();
    }
}
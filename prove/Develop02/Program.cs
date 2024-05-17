using System;
using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Formats.Asn1;
using System.Threading.Tasks.Dataflow;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        string userOption = "";
        
        while (userOption != "5")
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");
            Console.WriteLine("Choose an option: ");
            userOption = Console.ReadLine();

            switch (userOption)
            {
                case "1":
                    journal.AddNewEntry();
                    break;
                case "2":
                    journal.DisplayJournal();
                    break;
                case "3":
                    Console.Write("Enter filename to save to: ");
                    string saveFilename = Console.ReadLine();
                    journal.SaveJournalToFile(saveFilename);
                    break;
                case "4":
                    Console.Write("Enter filename to load form: ");
                    string loadFilename = Console.ReadLine();
                    journal.LoadJournalFromFIle(loadFilename);
                    break;
                case "5":
                    Console.WriteLine("Exiting rpogram.");
                    break;
                default:
                    Console.WriteLine("Invalid option. Please choose again.");
                    break;
            }
        }
    }
}

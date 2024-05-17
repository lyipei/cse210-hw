using System;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json.Serialization;
using System.Xml;
using System.Xml.Serialization;

public class Journal
{
    private List<Entry> entries;
    private List<string> prompts;

    public Journal()
    {
        entries = new List<Entry>();
        prompts = new List<string>
        {
            "What was the best part of my day?",
            "What is the thankful thing of my day?",
	        "What was the strongest emotion I felt today?",
	        "What was the interesting thing of my day?",
	        "Any disappoint or sad things of my day?"
        };
    }
    public void AddNewEntry()
    {
        Random rand = new Random();
        string prompt = prompts[rand.Next(prompts.Count)];
        Console.WriteLine(prompt);
        string response = Console.ReadLine();
        Console.Write("ENter your mood: ");
        string mood = Console.ReadLine();
        Console.Write("Enter today's weather: ");
        string weather = Console.ReadLine();
        string date = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        entries.Add(new Entry {Date = date, Prompt = prompt, Response = response, Mood = mood, Weather = weather});
    }
    public void DisplayJournal()
    {
        foreach (var entry in entries)
        {
            Console.WriteLine("----------------------------------");   
            Console.WriteLine($"Date: {entry.Date}");
            Console.WriteLine($"Prompt: {entry.Prompt}");
            Console.WriteLine($"Response: {entry.Response}");
            Console.WriteLine($"Mood: {entry.Mood}");
            Console.WriteLine($"Weather: {entry.Weather}");
            Console.WriteLine("----------------------------------");
        }
    }
    public void SaveJournalToFile(string filename)
    {
        XmlSerializer serializer = new XmlSerializer(typeof(List<Entry>));
        using (StreamWriter writer = new StreamWriter(filename))
        {
            serializer.Serialize(writer, entries);
        }
        Console.WriteLine("Journal saved successfully.");
    }
    public void LoadJournalFromFIle(string filename)
    {
        if (File.Exists(filename))
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Entry>));
            using (StreamReader reader = new StreamReader(filename))
            {
                entries = (List<Entry>)serializer.Deserialize(reader);
            }        
            Console.WriteLine("Journal loaded successfully.");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}

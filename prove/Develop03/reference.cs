
using System.Security;

public class Reference
{
    public string _book;
    public int _chapter;
    public int _startVerse;
    public int _endVerse;

    public Reference(string reference)
    {
        string[] parts = reference.Split(' ');

        if (parts.Length != 3 || !parts[2].Contains('-'))
        {
            throw new ArgumentException("Invalid reference format. Must be in the format 'Book Chapter StartVerse-EndVerse'.");
        }


        _book = parts[0];
        _chapter = int.Parse(parts[1]);
        string[] verses = parts[2].Split('-');
        _startVerse = int.Parse(verses[0]);
        _endVerse = int.Parse(verses[1]);
    }
    public override string ToString()
    {
        return $"{_book}{_chapter} : {_startVerse}-{_endVerse}";
    }
}
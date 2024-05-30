using System.Text;

public class Scripture
{
    public Reference Reference {get; private set;}
    private List<Word> Words;
    private static readonly Random rand = new Random();

    public Scripture(Reference reference, string text)
    {
        Reference = reference;
        Words = text.Split(new[] { ' ', '\n' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(word => new Word(word.Trim()))
                    .ToList();    
    }
    
    public void HideRandomWords(int wordsToHide)
    {
        List<Word> notHiddenWords = Words.Where(word => !word.HiddenWord).ToList();
        
        for (int i = 0; i < wordsToHide && notHiddenWords.Count >0; i++)
        {
            int index = rand.Next(notHiddenWords.Count);
            notHiddenWords[index].Hide();
            notHiddenWords.RemoveAt(index);
        }
    }
    public bool AllWordsHidden()
    {
        return Words.All(word => word.HiddenWord);
    }
    public string GetDisplayText()
    {
        StringBuilder displayText = new StringBuilder();
        displayText.AppendLine(Reference.ToString());

        foreach (var word in Words)
        {
            if (word.Text.EndsWith("15") || word.Text.EndsWith("16"))
                displayText.AppendLine(); // New line before new verse

            displayText.Append(word.ToString() + " ");    
        }
        return displayText.ToString().Trim();
    }

}
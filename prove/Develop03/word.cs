public class Word
{
    public string Text{get; private set;}
    public bool HiddenWord {get; private set;}

    public Word(string text)
    {
        Text = text;
        HiddenWord = false;
    }
    public void Hide()
    {
        HiddenWord = true;
    }
    public override string ToString()
    {
        return HiddenWord ? new string('_', Text.Length) : Text;
    }
}
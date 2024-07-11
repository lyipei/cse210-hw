using System.Security.Principal;

public class Comment
{
    public string _account;
    public string _text;

    public Comment(string account, string text)
    {
        _account = account;
        _text = text;
    }
    public string GetAccount()
    {
        return _account;
    }
    public string GetText()
    {
        return _text;
    }
}
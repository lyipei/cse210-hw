using System.Transactions;

public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments;
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }
    public void storeComment(Comment comment)
    {
        _comments.Add(comment);
    }
    public int GetCommentCount()
    {
        return _comments.Count;
    }
    public void Report()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {_length} seconds.");
        Console.WriteLine($"Number of comments: {GetCommentCount()}");
        foreach (var comment in _comments)
        {
            Console.WriteLine($"Commenter: {comment.GetAccount()}, Comment: {comment.GetText()}");
        }
    }
}
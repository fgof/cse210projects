using System;
public class Videos
{
    public string _title;
    public string _author;
    public double _length;

    public List<Comments> _comments = new List<Comments>();

    public void DiplayVideo()
    {
        Console.WriteLine($"'{_title}' by {_author}, {_length} seconds");
        Console.WriteLine($"{_comments.Count} comments");
        
        
        foreach (Comments comment in _comments)
        {
            comment.DisplayComment();
        }
        Console.WriteLine();
    }

}
using System;
using System.Collections.Generic;

public class Video
{
    // Properties for video information
    public string Title { get; }
    public string Author { get; }
    public int LengthInSeconds { get; }

    // List of comments for this video
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int lengthInSeconds)
    {
        Title = title;
        Author = author;
        LengthInSeconds = lengthInSeconds;
    }

    // Add a comment to this video
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    // Return the number of comments (required by the spec)
    public int GetNumberOfComments()
    {
        return _comments.Count;
    }

    // Provide read-only access to the comments (for display)
    public List<Comment> GetComments()
    {
        return _comments;
    }
}

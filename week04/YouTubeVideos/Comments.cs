using System;

public class Comment
{
    // Properties for the name of the commenter and the text of the comment
    public string CommenterName { get; }
    public string Text { get; }

    public Comment(string commenterName, string text)
    {
        CommenterName = commenterName;
        Text = text;
    }
}

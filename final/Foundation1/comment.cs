using System;
using System.Collections.Generic;

class Comment
{
    // Name and text from the commenter
    public string _CommenterName {get; set;}
    public string _CommentText {get; set;}
    // Commenter's name and text
    public Comment(string commenterName, string commentText)
    {
        _CommenterName = commenterName;
        _CommentText = commentText;
    }
}
using System;
using System.Collections.Generic;

class Comment
{
    public string _CommenterName {get; set;}
    public string _CommentText {get; set;}

    public Comment(string commenterName, string commentText)
    {
        _CommenterName = commenterName;
        _CommentText = commentText;
    }
}
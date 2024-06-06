
class Video
{
    public string _Title {get; set;}
    public string _Author {get; set;}
    public int _LengthSeconds {get; set;}
    public List<Comment> _Comments {get; set;}

    public Video(string title, string author, int lengthSeconds)
    {
        _Title = title;
        _Author = author;
        _LengthSeconds = lengthSeconds;
        _Comments = new List<Comment>();
    }

    public void AddComment(string commenterName, string commentText)
    {
        Comment comment = new Comment(commenterName, commentText);
        _Comments.Add(comment);
    }

    public int _GetNumComments()
    {
        return _Comments.Count;
    }

}
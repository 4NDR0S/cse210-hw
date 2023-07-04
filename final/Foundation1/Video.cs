class Video
{
    public string _title;
    public string _author;
    public int _lenght;


    public List<Comment> _comments = new List<Comment>();

    public void Display()
    {
        Console.WriteLine($"{_title} - {_author} ({_lenght} seconds)");
        Console.WriteLine($"Number of comments: {CommentsCount()}");
        
        int i = 1;
        foreach(Comment comment in _comments)
        {
            Console.WriteLine(i + ". " + comment.DisplayC());i++;
            // Console.WriteLine(i + ". " + g.GetName());i++;
        }
    }

    public int CommentsCount()
    {
        return _comments.Count;
    }

}
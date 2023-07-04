class Comment
{
    public string _name;
    public string _textComment;

    public string DisplayC()
    {
        return($"{_name}: {_textComment}");
    }
}
public class Comment
{
    string _author;
    string _content;

    public Comment(string Author, string Content)
    {
        _author = Author;
        _content = Content;
    }

    public string GetAuthor()
    {
        return _author;
    }

    public string GetContent()
    {
        return _content;
    }
}
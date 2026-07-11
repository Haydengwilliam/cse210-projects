public class Video
{
    string _title;
    string _author;
    int _length;
    List<Comment> _commentList;

    public Video(string Title, string Author, int Length, List<Comment> Comments)
    {
        _title = Title;
        _author = Author;
        _length = Length;
        _commentList = Comments;
    }

    public string GetAuthor()
    {
        return _author;
    }

    public string GetTitle()
    {
        return _title;
    }

    public int GetLength()
    {
        return _length;
    }

    public List<Comment> GetComments()
    {
        return _commentList;
    }

    public int GetCount()
    {
        return _commentList.Count();
    }
}
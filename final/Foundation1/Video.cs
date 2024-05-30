public class Video {
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length, List<(string, string)> comments) {
        _title = title;
        _author = author;
        _length = length;
        
        foreach (var data in comments) {
            Comment comment = new Comment(data.Item1, data.Item2);
            _comments.Add(comment);
        }
    }

    public int GetNumberOfComments() {
        return _comments.Count;
    }

    public void DisplayVideoInfo() {
        
        Console.WriteLine($"Title: {_title}, Author: {_author}, Length: {_length}, Number of Comments: {GetNumberOfComments()}");
        Console.WriteLine("Comments:");
        
        foreach (Comment comment in _comments) {
            Console.WriteLine($"{comment.GetName()}: {comment.GetText()}");
        }
        Console.WriteLine();
    }
}
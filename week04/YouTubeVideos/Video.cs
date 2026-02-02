using System;

class Video
{
    public string _title;
    public string _author;
    public int _length;

    public List<Comment> _comments = new List<Comment>();


    public void DisplayComments()
    {
       
        
        foreach (Comment comment in _comments)
        {
            Console.WriteLine($"Comment: {comment._name} _{comment._text}");
        }
        Console.WriteLine();


    }

}
using System;

// The responsibility is to track the title, author, and length (in seconds) of the video. 
// Each video also has responsibility to store a list of comments, and should have a method 
// to return the number of comments. 
class Video
{
    //Member variable
    private string _Title { get; } // Name of the video
    private string _Author { get; } // Author of the video
    private int _LengthOfVideo { get; } // Length of the video in seconds

    private List<Comment> _comments = new List<Comment>(); // List to store comments on this video

    // Constuctor to initialize video 
    public Video(string title, string author, int LengthOfVideo)
    {
        _Title = title;
        _Author = author;
        _LengthOfVideo = LengthOfVideo;
        _comments = new List<Comment>();
    }

    // Method to add a comment to the video
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    // Method to Get all comments
    public List<Comment> GetComments()
    {
        return _comments;
    }

    // Method to get the number of comments
    public int GetNumberOfComments()
    {
        return _comments.Count;
    }

    // Method to display video details and its comments
    public void DisplayVideoInfo()
    { 
        Console.WriteLine("=======================================================================");
        Console.WriteLine($"Video Name: {_Title} ");
        Console.WriteLine($"Author: {_Author} ");
        Console.WriteLine($"Length: {_LengthOfVideo} seconds");
        Console.WriteLine($"Number of Comments: {GetNumberOfComments()}");
        Console.WriteLine("Comments:");

        // Loop through each comment object in the _comments list
        foreach (Comment comment in _comments)
        {   
            // Print the commenter's name and the comment text 
            Console.WriteLine($"-{comment._CommenterName} : {comment._text}");
        }
        Console.WriteLine("=======================================================================");
    }
}
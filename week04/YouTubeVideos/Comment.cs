using System;
using System.Collections.Generic;

// The responsibility is tracking the name of the person who made the comment and it's comment text. 
class Comment
{
    public string _CommenterName { get; }
    public string _text { get; }

    //Construction to initialize comment
    public Comment(string commenterName, string text)
    {
        _CommenterName = commenterName;
        _text = text;
    }

}
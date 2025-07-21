using System;

//This class responsible for storing and displaying the reference 
//(i.e., the book, chapter, and verse or verse range) of a scripture passage.

public class Reference
{
    // 4 member Variables
    private string _book;//Stores the book name
    private int _chapter;//Stores the chapter number
    private int _verse;//Stores the starting verse
    private int _endVerse;//Stores the ending verse

    // first comstructor(3 params) for a single verse
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = verse; //_endVerse == _verse, 
                           // the code works the same way for both single and multiple verses.
    }

     // second comstructor(4 params) for a multiple verses
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse; //range from _verse to _endVerse
    }

    // method
    public string GetDisplayText()
    //Returns the reference as a formatted string
    {
        if (_verse == _endVerse)
                        //out put: e.g.,"John 3:16"
            return $"{_book} {_chapter}:{_verse}";
        else
                        //out put:e.g.,"John 3:16-18"
            return $"{_book} {_chapter}:{_verse} - {_endVerse}";
    }      

}


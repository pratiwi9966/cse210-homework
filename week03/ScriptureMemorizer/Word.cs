using System;
// This class responsible for Keeps track of a single word and whether it is shown or hidden.
public class Word
{
    // 2 member variables
    private string _text; //Stores the actual word text (e.g., "love").
    private bool _isHidden; //Tracks whether the word is hidden (true) or shown (false).

    // Constructor
    public Word(string text)
    {
        _text = text; //to stores the word text (e.g., "love") in the private _text variable
        _isHidden = false; // the word's is shown, not hidden(meaning the word is shown by default.)
    }

    // First Method: hides the word by setting _isHidden to true.
    // In other words, when this is called, the word is marked as hidden.
    public void Hide()
    {
        _isHidden = true;
    }

    // Second Method: shows the word again by setting _isHidden to false.
    // In other words, when this is called, the word shown again.
    public void Show()
    {
        _isHidden = false;
    }

    // Third Method: checks whether the word is hidden or not.
    // It returns true if the word is hidden, and false if it's shown.
    public bool IsHidden()
    {
        return _isHidden;
    }

    // Fourth Method: returns what should be displayed for the word
    // If the word is hidden, it returns a string of underscores _, with the same length as the word.
    // If the word is shown, it returns the actual word text.(_text)
    public string GetDisplayText()
    {
        if (_isHidden)
        {
            return new string('_', _text.Length);
            // new string(char character, int repeatCount) is a built-in constructor of the string class in C#.
            // It create a new string by repeating a character a certain number of times.
            // _text.Length gives the number of characters (letters) in the string _text.
            // Example: if _text = "love", then _text.Length = 4.

            // So, new string('_', _text.Length) creates and returns a string made up of underscores,
            // with the same number of underscores as there are characters in _text.
            // Example: new string('_', 4) would return "____"

        }
        else
        {
            return _text; //return actual word 
        }
    }

}
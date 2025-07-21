using System;
// The responsible is keeps track of both the reference and the text of the scripture. 
// Can hide words and get display of the text.
using System.Collections.Generic;
public class Scripture
{
    //2 Member variables 
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    // Constructor: accept a Reference object and a string includ the full scripture text (parameters)
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        //Split text into words and create Word objects and add it to the list
        foreach (string word in text.Split(' '))
        //Go through each word in the text, splitting by each space.
        //text.Split(' ')  breaks the text down into individual words separated by spaces.
        //.Split(): is the method that cut up a string into pieces.
        //(' '): is the argument passed to the Split() method, tells .Split() where to cut.
        // ex: "I love cat".Split(' ') -> result "I","love", "Cat"
        {
            _words.Add(new Word(word));
            // Create a new Word object using the word string, and add it to the _words list
        }
    }

    //First Method: Randomly hides a specified number of words.
    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        List<Word> visibleWords = new List<Word>();

        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                visibleWords.Add(word);
            }
        }

        for (int i = 0; i < numberToHide && visibleWords.Count > 0; i++)
        {
            int randomIndex = random.Next(visibleWords.Count);
            visibleWords[randomIndex].Hide();
            visibleWords.RemoveAt(randomIndex);

        }
    }

    // second Method: Returns the scripture text with some words 
    // shown normally and some replaced by underscores.
    public string GetDisplayText()
    {
        // Create an empty string to hold the verse
        string verseText = "";

        // Loop through each word in the list of words
        foreach (Word word in _words)
        {
            // Add the display version of the word, followed by a space
            verseText += word.GetDisplayText() + " ";
        }

        // Trim off any extra space at the end
        verseText = verseText.Trim();

        //Return the reference text and the verse tex together
        return _reference.GetDisplayText() + " - " + verseText;
    }

    // third Method: Checks if the entire scripture has been hidden—useful 
    // to determine when the program should end.
    public bool IsCompletelyHidden()
    {
        // loop through each word
        foreach (Word word in _words)
        {
            // If any word is not hidden, return false
            if (!word.IsHidden())
            {
                return false;
            }
        }

        // If we finished the loop, all words are hidden
        return true;
    }
    
}
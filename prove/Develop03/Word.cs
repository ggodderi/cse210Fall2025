using System.IO.Compression;
using System.Runtime.CompilerServices;

class Word
{
    private string _word;
    private bool _isHidden;

    public Word(string word)
    {
        _word = word;
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public void HideWord()
    {
        _isHidden = true;
    }

    private string LocalGetWordString()
    {
        // If the word is hidden, return underscore characters for the word
        // One for each character in the word.
        // Else return the actual word.
        
        if(_isHidden)
        {
            string newString = "";
            foreach(char c in _word)
            {
                newString += '_';
            }
            return newString;
        }
        else
            return _word;
    }

    public void DisplayWord()
    {
        Console.Write(LocalGetWordString());
    }

    public string GetWordString()
    {
        return LocalGetWordString();
    }

}
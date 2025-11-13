using System.Collections.Generic;

class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false; // Shows the actual word, thats why its false
    }

    // Flags the word as hidden
    public void Hide()
    {
        _isHidden = true;
    }

    // Flags the word as visible
    public void Show()
    {
        _isHidden = false;
    }

    // The Getter to return if 
    public string GetDisplayText()
    {
        if (_isHidden == true)
        {
            return new string('_', _text.Length); // string(character, word.Length)
        }
        else
        {
            return _text;
        }

    }

    // This is a fix with scripture class
    public bool GetIsHidden()
    {
        return _isHidden;
    }
}
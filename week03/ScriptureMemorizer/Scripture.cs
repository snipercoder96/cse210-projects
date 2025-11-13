using System.Collections.Generic;
class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] wordsInText = text.Split(' '); // we splitting the text that will be passed in here.

        foreach (string singleWord in wordsInText) // Loops through the wordsInText = text
        {
            Word wordObject = new Word(singleWord);
            _words.Add(wordObject);
        }
    }


    public void HideRandomWords(int numberToHide)
    {
        Random rand = new Random();

        List<Word> visibleWords = new List<Word>(); // Visible words

        foreach (Word wrd in _words)
        {
            if (!wrd.GetIsHidden())
            {
                visibleWords.Add(wrd);
            }
        }

        int toHide = Math.Min(numberToHide, visibleWords.Count); // If the number to hide count is > visibleWords Fix.


        for (int i = 0; i < toHide; i++)
        {
            int index = rand.Next(visibleWords.Count);
            visibleWords[index].Hide();
            visibleWords.RemoveAt(index);
        }
    }

    public string GetDisplayText()
    {
        string displayText = "";

        foreach (Word word in _words)
        {
            displayText += word.GetDisplayText() + " ";
        }

        return $"{_reference.GetDisplayText()} {displayText.Trim()}";

    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.GetIsHidden())
            {
                return false;
            }

        }

        return true;
    }
}
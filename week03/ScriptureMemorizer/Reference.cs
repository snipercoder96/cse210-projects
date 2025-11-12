class Reference 
{
    // Create Member variables (Encapsulate them!)
    private string _book;
    private int _chapter;
    private int _verse;

    // endVerse eg John 3:16 -18
    private int _endVerse;


    // Create two constructors
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse; // used verse as starting verse
        _endVerse = endVerse;
    }

    // Access Modifiers can be accessed in this line:
    public string GetDisplayText()
    {  
        if (_verse > 0 && _endVerse == 0)
        {
            return $"{_book} {_chapter}:{_verse}"
        }
        else
        {
            return $"{_book} {_chapter}:{_verse}-{_endVerse}"
        }
       
    }
}
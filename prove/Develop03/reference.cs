
class Reference {

    private int _chapter; 

    private string _book;

    private int _firstVerse;

    private int _lastVerse;

    public Reference(string book, int chapter, int firstVerse, int lastVerse) //Constructor to initialize each perameter as a private variable
    {
        _book = book;
        _chapter = chapter;
        _firstVerse = firstVerse;
        _lastVerse = lastVerse;
    }

    public Reference(string book, int chapter, int verse) // Constructor to initialize each perameter as a private variable and takes into account single verse
    {
        _book = book;
        _chapter = chapter;
        _firstVerse = verse;
        _lastVerse = verse;
    }

    public string FormattedReference() // Formatts the reference for proper use
    {
        if (_firstVerse == _lastVerse)
            return $"{_book} {_chapter}:{_firstVerse}";
        else
            return $"{_book} {_chapter}:{_firstVerse}-{_lastVerse}";
    }

}
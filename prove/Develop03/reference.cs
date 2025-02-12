
class Reference {

    private int _chapter;

    private string _book;

    private int _firstVerse;

    private int _lastVerse;

    public Reference(string book, int chapter, int firstVerse, int lastVerse)
    {
        _book = book;
        _chapter = chapter;
        _firstVerse = firstVerse;
        _lastVerse = lastVerse;
    }

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _firstVerse = verse;
        _lastVerse = verse;
    }


    public void Display()
    {
        if (_firstVerse == _lastVerse)
            Console.WriteLine($"{_book} {_chapter}:{_firstVerse}");
        else
            Console.WriteLine($"{_book} {_chapter}:{_firstVerse}-{_lastVerse}");
    }

}
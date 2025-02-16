class Word
{

    private string _word; //initializes word variable

    public Word(string word) //Constructor to make the perameter a private object
    {
        _word = word;
    }

    public string Hide() //Hides the word by replacing however long the word is with underscores
    {
        return new string('_', _word.Length);
    }

    public string Show() //If its not hidden it returns the unchanged word
    {
        return _word;
    }

    public string Render(bool hide) // Handles if the word should be hidden or not
{
    if (hide)
    {
        return Hide(); // Return underscores
    }
    else
    {
        return Show(); // Return the actual word
    }
}
}
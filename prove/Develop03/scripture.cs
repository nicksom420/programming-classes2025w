class Scripture
{

    private Random _random = new Random(); // Creates an instance of the random class to be used

    private List<int> _hiddenWords = new List<int>(); // Creates a list of indexes for the words to be hidden

    private List<Word> _objectScriptures = new List<Word>(); // A list of Word objects so that each word can be hidden or shown


    private List<string> _stringScriptures = new List<string>() // List of words that are contained in the scripture

    {
        "Now", "behold", "a", "marvelous", "work", "is", "about", "to", "come", "forth", "among", "the", "children", "of", "men;",
        "Therefore", "O", "ye", "that", "embark", "in", "the", "service", "of", "God", "see", "that", "ye", "serve", "him", "with", "all", "your", "heart", "might", "mind", "and", "strength", "that", "ye", "may", "stand", "blameless", "before", "God", "at", "the", "last", "day;",
    };

    public Scripture() //Constructor to initialize each word in the scripture as a Word object so it can be hidden or shown
    {
        foreach (string word in _stringScriptures)
        {
            _objectScriptures.Add(new Word(word));
        }
    }

    public void DisplayScripture() // Displays the scripture
    {
        for (int i = 0; i < _objectScriptures.Count; i++) // Iterates through each index to determine if it should be shown or hidden
        {
                Console.Write(_objectScriptures[i].Render(_hiddenWords.Contains(i)) + " "); //Checks if the word is in the hidden words list and hides it or shows it
        }
        Console.WriteLine();
    }

    public void HideRandomWords() // Selects the random words to hide
    {
        int wordsToHide = Math.Min(3, _objectScriptures.Count - _hiddenWords.Count); // Determines how many words it should hide, if there are less than 3 left it will hide the remainder

        int hiddenCount = 0; // stores how many words have been hidden
        while (hiddenCount < wordsToHide) // Loops as many times as the number of words that need to be hidden
        {
            int index = _random.Next(0, _objectScriptures.Count); // Gets a randomized index from the scripture list
            
            //Only hides words that have not been hidden
            if (!_hiddenWords.Contains(index))
            {
                _hiddenWords.Add(index);
                hiddenCount++;
            }
        }
    }

    public bool ifAllWordsAreHidden() // Shows if all the words have been hidden
    {
        return _hiddenWords.Count == _objectScriptures.Count;
    }
}
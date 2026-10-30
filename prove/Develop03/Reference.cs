

class Reference
{

    //attributes
    private List<Word> _words = [];
    private string _reference;

    //constructors
    public Reference(string reference)
    {
        _reference = reference;
    }

    public Reference(string reference, string scripture)
    {
        _reference = reference;
        AddVerse(scripture);
    }

    //methods
    private void AddVerse(string scripture)
    {
        string[] words = scripture.Split(" ");
        foreach (string word in words)
        {
            Word newWord = new Word(word);
            _words.Add(newWord);
        }
    }

    public void HideWords()
    {
        Random rand = new Random();

        //checks to see how many of the words are actually set to _isVisible = true
            int visible = 0;

            foreach (Word word in _words)
            {
                if (word.GetVisibility() == true)
                {
                    visible += 1;
                }
            }

        //sets up to 3 words to _isVisible = false if there are enough words
        for (int i=0; i < 3; ++i)
        {
            int hideIndex = rand.Next(_words.Count);

            Word checkWord = _words[hideIndex];

            //if the current word is visible, set it to _isVisible = false
            //and set the number of visible words down by 1. 
            //else, if there is only 1 visible word left, set all words to _isVisible = false 
            //else, set i back by 1 to repeat the loop until one of the first two conditions are met
            if (checkWord.GetVisibility() == true)
                {
                    checkWord.SetInvisible();

                    visible -= 1;
                }
            else if (visible < 2)
            {
                foreach (Word word in _words)
                {
                    word.SetInvisible();
                }
            }
            else
            {
                --i;
            }
        }
    }


    public string GetReference()
    {
        return _reference;
    }


    public void Display()
    {
        Console.Clear();
        Console.WriteLine(_reference);
        foreach (Word word in _words)
            {
                word.Display();
            }
        Console.WriteLine("");
    }

    public bool IsAllInvisible()
    {
        int visible = 0;
        foreach (Word word in _words)
        {
            if (word.GetVisibility() == true)
            {
                visible += 1;
            }
        }

        if (visible == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
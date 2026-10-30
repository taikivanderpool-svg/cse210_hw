

class Word
{
    //attributes
    private string _word;
    private bool _isVisible;


    //constructors
    public Word(string word)
    {
        _word = word;

        _isVisible = true;
    }


    //methods 
    public void SetInvisible()
    {
        _isVisible = false;
    }


    public bool GetVisibility()
    {
        return _isVisible;
    }


    public void Display()
    {
        if (_isVisible == true)
        {
            Console.Write(_word + " ");
        }
        else
        {
            Console.Write("____ ");
        }
    }

}



class Memorizer
{
    //attributes 
    private List<Reference> _references = [];
    private Reference _currentReference; 


    //methods
    public void PickReference()
    {
        int i = 1;
        Console.WriteLine("Which scriptures do you want to memorize?");
        foreach(Reference reference in _references)
        {
            Console.WriteLine($"{i}. {reference.GetReference()}");
            i++;
        }

        int referenceIndex = int.Parse(Console.ReadLine());
        _currentReference = _references[referenceIndex - 1];
    }

    public void IncreaseDifficulty()
    {
        Console.Clear();
        _currentReference.HideWords();
        _currentReference.Display();
    }


    public void AddReference(string reference, string scripture)
    {
        Reference newReference = new Reference(reference, scripture);
        _references.Add(newReference);
    }

    public void Display()
    {
        Console.Clear();
        _currentReference.Display();
    }

    public Reference GetCurrentReference()
    {
        return _currentReference;
    }

}
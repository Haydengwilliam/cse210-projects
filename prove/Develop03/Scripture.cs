public class Scripture
{

    Reference _ref;
    Passage _passage;
    public Scripture(Reference reference, Passage passage) 
    {
        _ref = reference;
        _passage = passage;
    }
    public string ToString()
    {
        string refString = _ref.ToString();
        string passageString = _passage.toString();

        return $"{refString} {passageString}";
    }
    public void hideWord()
    {
        _passage.hideWord();
    }
}
public class Word
{
    string _word;
    bool _hidden;

    public string ToString()
    {
        return $"{_word} ";
    }

    public Word(string word)
    {
        _word = word;
        _hidden = false;
    }

    public void hideWord(string word)
    {
        string hiddenWord = "";
        foreach (char letter in _word)
        {
            hiddenWord = hiddenWord + "_";
        }
        _word = hiddenWord;
        _hidden = true;
    }

    public bool isHidden()
    {
        return _hidden;
    }
}
public class Passage
{
    List<Word> _words;

    public string toString()
    {
        string output = "";
        foreach (Word word in _words)
        {
            output += word.ToString();
        }
        return output;
    }

    public Passage(List<Word> words)
    {
        _words = words;
    }

    public void hideWord()
    {
        int hiddenCount = 0;
        foreach (Word text in _words)
        {
            if (char.ToString(text.ToString()[0]) == "_")
            {
                hiddenCount += 1;
            }
        }
        var rand = new Random();
        int hideCount = rand.Next(5);
        for (int ctr = 0; ctr <= hideCount; ctr++)
        {
            int hideIndex = rand.Next(_words.Count);
            if (!_words[hideIndex].ToString().Contains("_"))
            {
                _words[hideIndex].hideWord(_words[hideIndex].ToString());
            }
            else if (_words.All(c => c.ToString().Contains("_")))
            {
                break;
            }
            else
            {
                ctr--;
            }

        }
    }
}
using System;
class Program
{
    static void Main(string[] args)
    {   
        Tuple<string, int> referenceTuple = GenerateReference();
        Reference memReference = new Reference(referenceTuple.Item1);
        Passage memPassage = new Passage(GetPassage(referenceTuple.Item2));
        Scripture memScripture = new Scripture(memReference, memPassage);
        bool keepRunning = true;
        string hiddenPassage = memPassage.toString();

        Console.WriteLine($"{memScripture.ToString()}\n");
        while (keepRunning == true)
        {
            Console.Write("Press Enter to continue or type 'quit' to finish:\n");
            string userInput = Console.ReadLine().ToLower();
            if (userInput == "quit" || userInput == "q")
            {
                keepRunning = false;
            }
            else
            {
                bool allBlank = hiddenPassage.All(c => c.ToString().Contains(" ") || c.ToString().Contains("_"));
                if (allBlank)
                {
                    keepRunning = false;
                }
                else
                {
                    Console.Clear();
                    memScripture.hideWord();
                    Console.WriteLine(memScripture.ToString());
                }
                string memScriptureString = memScripture.ToString();
                hiddenPassage = memScriptureString.Remove(0, memScriptureString.IndexOf(" ", memScriptureString.IndexOf(":")));
            }
        }
    }

    static Tuple<string, int> GenerateReference()
    {
        string[] references = [
            "1 Nephi 1:1",
            "1 Nephi 1:2",
            "1 Nephi 1:3",
            "1 Nephi 1:4",
            "1 Nephi 1:5",
            "1 Nephi 1:6-7"
        ];
        Random random = new Random();
        int referenceIndex = random.Next(references.Length);
        string reference = references[referenceIndex];
        return Tuple.Create(reference, referenceIndex);
    }

    static List<Word> GetPassage(int passageIndex)
    {
        string[] passages = [
            "I, Nephi, having been born of goodly parents, therefore I was taught somewhat in all the learning of my father; and having seen many afflictions in the course of my days, nevertheless, having been highly favored of the Lord in all my days; yea, having had a great knowledge of the goodness and the mysteries of God, therefore I make a record of my proceedings in my days.",
            "Yea, I make a record in the language of my father, which consists of the learning of the Jews and the language of the Egyptians.",
            "And I know that the record which I make is true; and I make it with mine own hand; and I make it according to my knowledge.",
            "For it came to pass in the commencement of the first year of the reign of Zedekiah, king of Judah, (my father, Lehi, having dwelt at Jerusalem in all his days); and in that same year there came many prophets, prophesying unto the people that they must repent, or the great city Jerusalem must be destroyed.",
            "Wherefore it came to pass that my father, Lehi, as he went forth prayed unto the Lord, yea, even with all his heart, in behalf of his people.",
            "And it came to pass as he prayed unto the Lord, there came a pillar of fire and dwelt upon a rock before him; and he saw and heard much; and because of the things which he saw and heard he did quake and tremble exceedingly. And it came to pass that he returned to his own house at Jerusalem; and he cast himself upon his bed, being overcome with the Spirit and the things which he had seen."
        ];
        List<Word> passage = [];
        foreach (string wordString in passages[passageIndex].Split(" "))
        {
            Word tempWord = new Word(wordString);
            passage.Add(tempWord);
        }
        return passage;
    }
}
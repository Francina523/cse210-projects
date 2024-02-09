// Class representing a single word in the scripture
    public class Word
    {
        public string ScriptureWord { get; }
        public bool Hidden { get; set; }

        public Word(string word)
        {
            ScriptureWord = word;
            Hidden = false;
        }
    }
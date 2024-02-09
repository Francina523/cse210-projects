// Class representing a scripture
     public class Scripture
    {
        public Reference Reference { get; }
        public List<Word> Words { get; }

        public Scripture(Reference reference, string text)
        {
            Reference = reference;
            Words = text.Split(' ').Select(word => new Word(word)).ToList();
        }

        // Method to hide a random word in the scripture
        public void HideRandomWord()
        {
            Random random = new Random();
            int index = random.Next(Words.Count);
            Words[index].Hidden = true;
        }

        // Method to check if all words are hidden
        public bool AllWordsHidden()
        {
            return Words.All(word => word.Hidden);
        }

        // Method to get the scripture text with hidden words
        public string GetScriptureText()
        {
            string text = "";
            foreach (var word in Words)
            {
                if (word.Hidden)
                    text += "_____ ";
                else
                    text += word.ScriptureWord + " ";
            }
            return text.Trim();
        }
    }

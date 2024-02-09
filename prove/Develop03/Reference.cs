// Class representing a scripture reference
    public class Reference
    {
        public string Book { get; }
        public int StartVerse { get; }
        public int EndVerse { get; }

        // Constructor for a single verse
        public Reference(string book, int startVerse)
        {
            Book = book;
            StartVerse = startVerse;
            EndVerse = startVerse;
        }

        // Constructor for a verse range
        public Reference(string book, int startVerse, int endVerse)
        {
            Book = book;
            StartVerse = startVerse;
            EndVerse = endVerse;
        }

        // Method to format the scripture reference
        public string FormatReference()
        {
            if (StartVerse == EndVerse)
                return $"{Book} {StartVerse}";
            else
                return $"{Book} {StartVerse}-{EndVerse}";
        }
    }
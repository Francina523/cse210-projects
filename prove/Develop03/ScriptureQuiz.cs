// Class representing a scripture quiz
    public class ScriptureQuiz
    {
        private readonly List<Scripture> _scriptures;
        private int _currentScriptureIndex;

        public ScriptureQuiz()
        {
            _scriptures = new List<Scripture>();
            _currentScriptureIndex = -1;
        }

        // Add a scripture to the quiz
        public void AddScripture(Scripture scripture)
        {
            _scriptures.Add(scripture);
        }

        // Start the quiz
        public void Start()
        {
            _currentScriptureIndex = 0;
            Next();
        }

        // Display the current scripture
        public void DisplayScripture()
        {
            var currentScripture = _scriptures[_currentScriptureIndex];
            Console.WriteLine("Press Enter to hide a word or type 'quit' to end.");
            Console.WriteLine(currentScripture.Reference.FormatReference() + " " + currentScripture.GetScriptureText());
        }

        // Hide a word in the current scripture
        public void HideWord()
        {
            _scriptures[_currentScriptureIndex].HideRandomWord();
            Console.Clear();
            DisplayScripture();
        }

        // Move to the next scripture in the quiz
        public void Next()
        {
            if (_currentScriptureIndex >= 0 && _currentScriptureIndex < _scriptures.Count)
            {
                DisplayScripture();
            }
            else
            {
                Console.WriteLine("End of quiz.");
                return;
            }
        }
    }

    
using System;
using System.Collections.Generic;
using System.Linq;

namespace ScriptureMemorizationProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // Example usage
            Reference reference = new Reference("John", 3, 16);
            Scripture scripture = new Scripture(reference, "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");

            Console.WriteLine("Press enter to hide a word or type 'quit' to end.");
            Console.WriteLine(scripture.Reference.FormatReference() + " " + scripture.GetScriptureText());

            while (!scripture.AllWordsHidden())
            {
                string input = Console.ReadLine();
                if (input.ToLower() == "quit")
                    break;

                scripture.HideRandomWord();
                Console.Clear();
                Console.WriteLine(scripture.Reference.FormatReference() + " " + scripture.GetScriptureText());
            }

            Console.WriteLine("All words are hidden. Press any key to exit.");
            Console.ReadKey();
        }
    }
}

    

    
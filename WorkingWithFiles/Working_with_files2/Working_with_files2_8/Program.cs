using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Working_with_files2_8
{
    internal class Program
    {
        /// <summary>
        /// A program to remove the new line characters from a file
        /// </summary>
        /// <param name="args"></param>
        private static void Main(string[] args)
        {
            var text = File.ReadAllText("Asimov.txt");

            var usefulCharacters = new List<char>();

            var newLineCharacters = new[] {'\r', '\n'};

            foreach (var character in text)
                if (!newLineCharacters.Contains(character))
                    usefulCharacters.Add(character);

            //Build a string object from the collection of characters
            var cleanedText = new string(usefulCharacters.ToArray());

            File.WriteAllText("Asimov2.txt", cleanedText);
        }
    }
}
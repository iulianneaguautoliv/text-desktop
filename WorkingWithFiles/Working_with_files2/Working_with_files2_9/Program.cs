using System.Collections.Generic;
using System.IO;

namespace Working_with_files2_9
{
    internal class Program
    {
        /// <summary>
        ///     A program to replaces tabs with four space characters in a file.
        /// </summary>
        /// <param name="args"></param>
        private static void Main(string[] args)
        {
            var text = File.ReadAllText("Asimov.txt");

            var usefulCharacters = new List<char>();

            foreach (var character in text)
                if (!character.Equals('\t'))
                {
                    usefulCharacters.Add(character);
                }
                else
                {
                    usefulCharacters.Add(' ');
                    usefulCharacters.Add(' ');
                    usefulCharacters.Add(' ');
                    usefulCharacters.Add(' ');
                }

            //Build a string object from the collection of characters
            var cleanedText = new string(usefulCharacters.ToArray());

            File.WriteAllText("Asimov2.txt", cleanedText);
        }
    }
}
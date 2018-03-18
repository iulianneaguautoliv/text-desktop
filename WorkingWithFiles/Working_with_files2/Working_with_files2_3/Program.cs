using System;
using System.Collections.Generic;
using System.IO;

namespace Working_with_files2_3
{
    internal class Program
    {
        /// <summary>
        /// A program to count the number of words in a file
        /// </summary>
        /// <param name="args"></param>
        private static void Main(string[] args)
        {
            var allWords = new List<string>();

            var text = File.ReadAllText("Asimov.txt");

            var usefulCharacters = new List<char>();

            foreach (var character in text)
                if (char.IsWhiteSpace(character) || char.IsLetterOrDigit(character))
                    usefulCharacters.Add(character);

            //Build a string object from the collection of characters
            var cleanedText = new string(usefulCharacters.ToArray());

            //Split method splits a string into substrings based on the character given as argument.
            //See https://msdn.microsoft.com/en-us/library/b873y76a(v=vs.110).aspx
            var cleanedTextParts = cleanedText.Split(' ', '\r', '\n');

            foreach (var possibleWord in cleanedTextParts)
            {
                //trim method removes all leading and trailing white-space characters
                var trimmedWord = possibleWord.Trim();

                if (trimmedWord.Equals(string.Empty))
                    continue; //filter elements that are not words

                allWords.Add(trimmedWord);
            }

            var numberOfWords = allWords.Count;

            Console.WriteLine("Total number of words is " + numberOfWords);
        }
    }
}
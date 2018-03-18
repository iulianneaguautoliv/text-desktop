using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Working_with_files2_2
{
    internal class Program
    {
        /// <summary>
        /// A program to display the longest 4 words from a file.
        /// </summary>
        /// <param name="args"></param>
        private static void Main(string[] args)
        {
            var allWords = new List<string>();

            var text = File.ReadAllText("Asimov.txt");

            var usefulCharacters = new List<char>();

            foreach (var character in text)
            {
                if (char.IsWhiteSpace(character) || char.IsLetterOrDigit(character))
                {
                    usefulCharacters.Add(character);
                }
            }

            //Build a string object from the collection of characters
            var cleanedText = new String(usefulCharacters.ToArray());

            //Split method splits a string into substrings based on the characters given as argument.
            //See https://msdn.microsoft.com/en-us/library/b873y76a(v=vs.110).aspx
            var cleanedTextParts = cleanedText.Split(' ', '\r', '\n');

            foreach (var possibleWord in cleanedTextParts)
            {
                //trim method removes all leading and trailing white-space characters
                var trimmedWord = possibleWord.Trim();

                if (trimmedWord.Equals(string.Empty))
                    continue;//filter elements that are not words

                allWords.Add(trimmedWord);
            }

            //OrderByDescending method sorts the elements of a sequence in descending order according to a key.
            //In this case, the key is the length of word
            var wordsOrderByLength = allWords.OrderByDescending(word => word.Length);
            
            //Take method returns a new collection with only the first specified number of elements
            var bestWords = wordsOrderByLength.Take(4);

            foreach (var word in bestWords)
            {
                Console.WriteLine(word);   
            }
        }
    }
}
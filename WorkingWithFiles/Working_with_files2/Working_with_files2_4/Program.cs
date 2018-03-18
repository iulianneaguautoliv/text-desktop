using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Working_with_files2_4
{
    internal class Program
    {
        /// <summary>
        /// A program to count the frequency of words in a file
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

            //Split method splits a string into substrings based on the characters given as argument.
            //See https://msdn.microsoft.com/en-us/library/b873y76a(v=vs.110).aspx
            var cleanedTextParts = cleanedText.Split(' ', '\r', '\n');

            foreach (var possibleWord in cleanedTextParts)
            {
                //trim method removes all leading and trailing white-space characters
                var trimmedWord = possibleWord.Trim();

                if (trimmedWord.Equals(string.Empty))
                    continue; //filter elements that are not words

                allWords.Add(trimmedWord.ToLower());
            }

            //The word frequency can be counted by holding the words in a dictionary
            //The key can be the word
            //The value can be the number of times the word was found
            var wordFrequency = new Dictionary<string,int>();

            foreach (var word in allWords)
            {                
                if (!wordFrequency.ContainsKey(word))
                {
                    //This is the first time the word was found
                    wordFrequency.Add(word,1);
                }
                else
                {
                    //This is not the first time the word was found, so the counter will be increased
                    wordFrequency[word] += 1;
                }
            }

            foreach (var wordCounter in wordFrequency)
            {
                Console.WriteLine(wordCounter.Key+" "+wordCounter.Value);
            }
        }
    }
}
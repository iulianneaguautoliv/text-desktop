using System;
using System.IO;
using System.Linq;

namespace Working_with_files2
{
    internal class Program
    {
        /// <summary>
        /// A program to display the last 3 lines of a file.
        /// </summary>
        /// <remarks>
        /// TODO:This will have a problem if the file is too big (all of it will be loaded in memory).Improve solution.
        /// </remarks>
        /// <param name="args"></param>
        private static void Main(string[] args)
        {
            //Reads all the lines from the file in an array, each line representing a row
            var allLines = File.ReadAllLines("Asimov.txt");

            //Extension methods like "Skip" can be called on all collections that inherit from IEnumerable.
            //To get the last three lines, we must skip the rest.
            //To get the number of lines that must be skipped, we look at the total number and substract the number three (the ones we want to keep).
            //What if the file has less than 3 lines? Math.Max is used to avoid getting a negative number (ex: 2-3 = -1).
            var lastThree = allLines.Skip(Math.Max(0, allLines.Length - 3));

            //loop through the lines obtained and display them
            foreach (var line in lastThree)
            {
                Console.WriteLine(line);
            }

        }
    }
}
using System.Collections.Generic;
using System.IO;

namespace Working_with_files2_7
{
    internal class Program
    {
        /// <summary>
        ///     A program to merge the contents of two files and write the result in a new file (one line from each file).
        /// </summary>
        /// <param name="args"></param>
        private static void Main(string[] args)
        {
            var firstFileLines = File.ReadAllLines("Asimov.txt");

            var secondFileLines = File.ReadAllLines("Asimov2.txt");

            var thirdFileLines = new List<string>();

            var counter = 0;

            var firstFileIsDone = false;

            var secondFileIsDone = false;

            while (!firstFileIsDone || !secondFileIsDone)
            {
                if (firstFileLines.Length - 1 < counter)
                    firstFileIsDone = true;
                else
                    thirdFileLines.Add(firstFileLines[counter]);

                if (secondFileLines.Length - 1 < counter)
                    secondFileIsDone = true;
                else
                    thirdFileLines.Add(secondFileLines[counter]);

                counter++;
            }

            File.WriteAllLines("Asimov3.txt", thirdFileLines);
        }
    }
}
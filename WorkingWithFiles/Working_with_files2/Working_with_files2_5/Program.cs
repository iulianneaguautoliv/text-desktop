using System.IO;
using System.Linq;

namespace Working_with_files2_5
{
    internal class Program
    {
        /// <summary>
        /// A program to copy the contents of a file to a new file, without the third row
        /// </summary>
        /// <param name="args"></param>
        private static void Main(string[] args)
        {
            //The variable will contain an array with the lines from the file.
            var textLines = File.ReadAllLines("Asimov.txt");

            //change the array to a list
            var textLines2 = textLines.ToList();

            //The list type has a method to remove an element at a certain position
            textLines2.RemoveAt(2);//The first element is 0, the third is 2

            File.WriteAllLines("Asimov2.txt", textLines2);
        }
    }
}
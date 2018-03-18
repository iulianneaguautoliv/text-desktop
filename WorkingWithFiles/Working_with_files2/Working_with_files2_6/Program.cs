using System.IO;

namespace Working_with_files2_6
{
    internal class Program
    {
        /// <summary>
        ///     A program to copy the contents of a file and add it to the end of a second file.
        /// </summary>
        /// <param name="args"></param>
        private static void Main(string[] args)
        {
            //The variable will contain an array with the lines from the file.
            var text = File.ReadAllText("Asimov.txt");

            File.AppendAllText("Asimov2.txt", text);
        }
    }
}
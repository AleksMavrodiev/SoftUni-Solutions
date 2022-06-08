namespace LineNumbers
{
    using System;
    using System.IO;
    using System.Linq;

    public class LineNumbers
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";
            string outputFilePath = @"..\..\..\output.txt";

            ProcessLines(inputFilePath, outputFilePath);
        }

        public static void ProcessLines(string inputFilePath, string outputFilePath)
        {
            string[] lines = File.ReadAllLines(inputFilePath);
            StreamWriter writer = new StreamWriter(outputFilePath);
            using (writer)
            {
                int count = 0;
                foreach (var line in lines)
                {
                    count++;
                    int letterCount = line.Count(char.IsLetter);
                    int signCount = line.Count(char.IsPunctuation);
                    string modifiedLine = $"Line {count}: {line} ({letterCount})({signCount})";
                    writer.WriteLine(modifiedLine);
                }
            }
        }
    }
}

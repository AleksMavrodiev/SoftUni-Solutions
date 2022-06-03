namespace WordCount
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    public class WordCount
    {
        static void Main()
        {
            string wordPath = @"..\..\..\Files\words.txt";
            string textPath = @"..\..\..\Files\text.txt";
            string outputPath = @"..\..\..\Files\output.txt";

            CalculateWordCounts(wordPath, textPath, outputPath);
        }

        public static void CalculateWordCounts(string wordsFilePath, string textFilePath, string outputFilePath)
        {
            Dictionary<string, int> occurances = new Dictionary<string, int>();
            StreamReader reader = new StreamReader(wordsFilePath);
            using (reader)
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] words = line.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                    for (int i = 0; i < words.Length; i++)
                    {
                        if (!occurances.ContainsKey(words[i].ToLower()))
                        {
                            occurances.Add(words[i].ToLower(), 0);
                        }
                    }
                }
            }
            StreamReader textReader = new StreamReader(textFilePath);
            using (textReader)
            {
                string line;
                while ((line = textReader.ReadLine()) != null)
                {
                    string[] words = line.Trim('-').Split(" ", StringSplitOptions.RemoveEmptyEntries);
                    for (int i = 0; i < words.Length; i++)
                    {
                        if (occurances.ContainsKey(words[i].ToLower()))
                        {
                            occurances[words[i].ToLower()]++;
                        }
                    }
                }
            }
            var sortedOccur = occurances.OrderByDescending(x => x.Value);
            StreamWriter writer = new StreamWriter(outputFilePath);
            using (writer)
            {
                foreach (var item in sortedOccur)
                {
                    writer.WriteLine($"{item.Key} - {item.Value}");
                }
            }
        }
    }
}

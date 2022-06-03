namespace OddLines
{
    using System;
    using System.IO;

    public class OddLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\input.txt";
            string outputFilePath = @"..\..\..\output.txt";

            ExtractOddLines(inputFilePath, outputFilePath);
        }

        public static void ExtractOddLines(string inputFilePath, string outputFilePath)
        {
            StreamReader reader = new StreamReader(inputFilePath);
            using (reader)
            {
                StreamWriter writer = new StreamWriter(outputFilePath);
                using (writer)
                {
                    int lineNum = 0;
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        if (lineNum % 2 == 1)
                        {
                            writer.WriteLine(line);
                            
                        }
                        lineNum++;
                    }
                }
            }
        }
    }
}

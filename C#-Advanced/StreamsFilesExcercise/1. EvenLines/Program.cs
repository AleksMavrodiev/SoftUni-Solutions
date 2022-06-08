namespace EvenLines
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class EvenLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";

            Console.WriteLine(ProcessLines(inputFilePath));
        }

        public static string ProcessLines(string inputFilePath)
        {
            StreamReader reader = new StreamReader(inputFilePath);
            using (reader)
            {
                int counter = -1;
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    
                    counter++;
                    if (counter % 2 == 0)
                    {
                        line = Replace(line);
                        line = Reverse(line);
                        return line;
                    }
                }
                return null;
            }
        }

        private static string Reverse(string line)
        {
            return String.Join(" ", line.Split().Reverse());
        }

        private static string Replace(string line)
        {
            return line.Replace("-", "@").Replace(",", "@").Replace(".", "@").Replace("!", "@").Replace("?", "@");
        }
    }
}

namespace ExtractSpecialBytes
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class ExtractSpecialBytes
    {
        static void Main()
        {
            string binaryFilePath = @"..\..\..\Files\example.png";
            string bytesFilePath = @"..\..\..\Files\bytes.txt";
            string outputPath = @"..\..\..\Files\output.bin";

            ExtractBytesFromBinaryFile(binaryFilePath, bytesFilePath, outputPath);
        }

        public static void ExtractBytesFromBinaryFile(string binaryFilePath, string bytesFilePath, string outputPath)
        {
                  
            var buf = new byte[1024];
            using (var special = new FileStream(bytesFilePath, FileMode.Open))
            {
                while (true)
                {
                    int bytesRead = special.Read(buf);
                    if (bytesRead == 0)
                    {
                        break;
                    }
                    
                }
            }
        }
    }
}

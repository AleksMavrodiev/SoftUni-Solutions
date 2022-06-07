namespace ExtractBytes
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class ExtractBytes
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
            var reader = new StreamReader(bytesFilePath);
            List<byte> bytes = new List<byte>();
            using (reader)
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    bytes.Add(byte.Parse(line));
                }
            }
            using (var fin = new FileStream(binaryFilePath, FileMode.Open))
            {
                using (var fout = new FileStream(outputPath, FileMode.Create))
                {
                    byte[] buffer = new byte[4096];
                    while (true)
                    {
                        int bytesRead = fin.Read(buffer);
                        if (bytesRead == 0)
                        {
                            break;
                        }
                        for (int i = 0; i < bytesRead; i++)
                        {
                            if (bytes.Contains(buffer[i]))
                            {
                                fout.WriteByte(buffer[i]);
                            }
                        }
                    }
                }
            }
         
            
           
        }
    }
}

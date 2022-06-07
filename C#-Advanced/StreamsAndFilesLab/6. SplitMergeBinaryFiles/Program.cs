namespace SplitMergeBinaryFile
{
    using System;
    using System.IO;
    using System.Linq;

    public class SplitMergeBinaryFile
    {
        static void Main()
        {
            string sourceFilePath = @"..\..\..\Files\example.png";
            string joinedFilePath = @"..\..\..\Files\example-joined.png";
            string partOnePath = @"..\..\..\Files\part-1.bin";
            string partTwoPath = @"..\..\..\Files\part-2.bin";

            SplitBinaryFile(sourceFilePath, partOnePath, partTwoPath);
            MergeBinaryFiles(partOnePath, partTwoPath, joinedFilePath);
        }

        public static void SplitBinaryFile(string sourceFilePath, string partOneFilePath, string partTwoFilePath)
        {
            long length = new System.IO.FileInfo(sourceFilePath).Length;
            long size1 = length / 2;
            long size2 = length - size1;
            byte[] buf1 = new byte[size1];
            byte[] buf2 = new byte[size2];
            using (var fin = new FileStream(sourceFilePath, FileMode.Open))
            {
                using (var firstSplit = new FileStream(partOneFilePath, FileMode.Create))
                {
                    int readBytes = fin.Read(buf1);
                    firstSplit.Write(buf1);
                }
                using (var secindSplit = new FileStream(partTwoFilePath, FileMode.Create))
                {
                    int readBytes = fin.Read(buf2);
                    secindSplit.Write(buf2);
                }
            }
        }

        public static void MergeBinaryFiles(string partOneFilePath, string partTwoFilePath, string joinedFilePath)
        {
            using (var fin = new FileStream(joinedFilePath, FileMode.Create))
            {
                using (var readFirst = new FileStream(partOneFilePath, FileMode.Open))
                {
                    byte[] buffer = new byte[4096];
                    while (true)
                    {
                        int bytesRead = readFirst.Read(buffer);
                        if (bytesRead == 0)
                        {
                            break;
                        }
                        fin.Write(buffer, 0, bytesRead);
                    }
                }
                using (var readSecond = new FileStream(partTwoFilePath, FileMode.Open))
                {
                    byte[] buffer = new byte[4096];
                    while (true)
                    {
                        int bytesRead = readSecond.Read(buffer);
                        if (bytesRead == 0)
                        {
                            break;
                        }
                        fin.Write(buffer, 0, bytesRead);
                    }
                }
            }
        }
    }
}
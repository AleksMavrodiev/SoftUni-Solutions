namespace CopyBinaryFile
{
    using System;
    using System.IO;

    public class CopyBinaryFile
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\copyMe.png";
            string outputFilePath = @"..\..\..\copyMe-copy.png";

            CopyFile(inputFilePath, outputFilePath);
        }

        public static void CopyFile(string inputFilePath, string outputFilePath)
        {
            using (FileStream reader = new FileStream(inputFilePath, FileMode.Open))
            {
                using (FileStream writer = new FileStream(outputFilePath, FileMode.Create))
                {
                    while (true)
                    {
                        byte[] buf = new byte[4096];
                        int bytesRead = reader.Read(buf, 0, buf.Length);
                        if (bytesRead == null)
                        {
                            break;
                        }

                        writer.Write(buf, 0, bytesRead);
                    }
                }
            }
        }
    }
}

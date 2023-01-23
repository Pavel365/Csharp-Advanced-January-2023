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
            using (FileStream fileStream = new FileStream(inputFilePath, FileMode.Open))
            {
                using (FileStream writer = new FileStream(outputFilePath, FileMode.Create))
                {
                    byte[] buffer = new byte[512];
                    int size = 0;

                    while((size = fileStream.Read(buffer, 0, (int)buffer.Length)) != 0)
                    {
                        writer.Write(buffer, 0, size);
                    }
                }
            }
        }
    }
}

namespace FolderSize
{
    using System;
    using System.IO;
    public class FolderSize
    {
        static void Main(string[] args)
        {
            string folderPath = @"..\..\..\Files\TestFolder";
            string outputPath = @"..\..\..\Files\output.txt";

            GetFolderSize(folderPath, outputPath);
        }

        public static void GetFolderSize(string folderPath, string outputFilePath)
        {
            long getfilesize = GetFolderSize(folderPath, 0);
            Console.WriteLine($"{getfilesize / 1024} KB");
        }


        public static long GetFolderSize(string folderPath, int level)
        {
            string[] filesPaths = Directory.GetFiles(folderPath);

            long size = 0;
            foreach (string filePath in filesPaths)
            {
                FileInfo fileInfo = new FileInfo(filePath);
                size += fileInfo.Length;
            }

            foreach (var dirPaths in Directory.GetDirectories(folderPath))
            {
                size += GetFolderSize(dirPaths, level + 1);
            }

            return size;
        }
    }
}

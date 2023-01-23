namespace DirectoryTraversal
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;

    public class DirectoryTraversal
    {
        static void Main()
        {
            string path = Console.ReadLine();
            string reportFileName = @"\report.txt";

            string reportContent = TraverseDirectory(path);
            Console.WriteLine(reportContent);

            WriteReportToDesktop(reportContent, reportFileName);
        }

        public static string TraverseDirectory(string inputFolderPath)
        {
            SortedDictionary<string, List<FileInfo>> extentionsFiles = new SortedDictionary<string, List<FileInfo>>();

            string[]fileNames = Directory.GetFiles(inputFolderPath);

            foreach (string fileName in fileNames)
            {
                FileInfo fileInfo = new FileInfo(fileName);

                if (!extentionsFiles.ContainsKey(fileInfo.Extension))
                {
                    extentionsFiles.Add(fileInfo.Extension, new List<FileInfo>());
                }

                extentionsFiles[fileInfo.Extension].Add(fileInfo);
            }

            StringBuilder sb = new StringBuilder();

            foreach (var extentionFiles in extentionsFiles.OrderByDescending(ef => ef.Value))
            {
                sb.AppendLine(extentionFiles.Key);

                foreach (var file in extentionFiles.Value.OrderBy(f => f.Length))
                {
                    sb.AppendLine($"--{file.Name} - {((double)file.Length/1024):F3}kb");
                }
            }

            return sb.ToString();
        }

        public static void WriteReportToDesktop(string textContent, string reportFileName)
        {
            string filePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) 
                + reportFileName;
            File.WriteAllText(filePath, textContent);
        }
    }
}

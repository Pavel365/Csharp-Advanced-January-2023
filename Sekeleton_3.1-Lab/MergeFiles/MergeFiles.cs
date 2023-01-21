namespace MergeFiles
{
    using System;
    using System.IO;
    public class MergeFiles
    {
        static void Main()
        {
            var firstInputFilePath = @"..\..\..\Files\input1.txt";
            var secondInputFilePath = @"..\..\..\Files\input2.txt";
            var outputFilePath = @"..\..\..\Files\output.txt";

            MergeTextFiles(firstInputFilePath, secondInputFilePath, outputFilePath);
        }

        public static void MergeTextFiles(string firstInputFilePath, string secondInputFilePath, string outputFilePath)
        {
            using (StreamReader readerText1 = new StreamReader(firstInputFilePath)) 
            {
                using (StreamReader readerTeaxt2 = new StreamReader(secondInputFilePath))
                {
                    using (StreamWriter writer = new StreamWriter(outputFilePath))
                    {
                        string currentLine1 = readerText1.ReadLine();
                        string currentLine2 = readerTeaxt2.ReadLine();

                        while (currentLine1 != null || currentLine2 != null)
                        {
                            writer.WriteLine(currentLine1);
                            writer.WriteLine(currentLine2);

                            currentLine1 = readerText1.ReadLine();
                            currentLine2 = readerTeaxt2.ReadLine();
                        }
                    }
                }
            }
        }
    }
}

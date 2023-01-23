namespace EvenLines
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Text;

    public class EvenLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";

            Console.WriteLine(ProcessLines(inputFilePath));
        }

        public static string ProcessLines(string inputFilePath)
        {
            StringBuilder sb = new StringBuilder();

            using (StreamReader streamReader = new StreamReader(inputFilePath))
            {
                string line = "";
                int count = 0;

                while ((line = streamReader.ReadLine()) != null)
                {
                    if (count % 2 == 0)
                    {
                        string replacedSymbols = ReplaceSymbols(line);
                        string revercedWords = ReverseWords(replacedSymbols);
                        sb.AppendLine(revercedWords);
                    }

                    count++;
                }
            }

            return sb.ToString();
        }

        private static string ReverseWords(string replacedSymbols)
        {
            string[] revercedWords = replacedSymbols
                .Split(" ")
                .Reverse()
                .ToArray();

            return string.Join(" ", revercedWords);
        }

        private static string ReplaceSymbols(string line)
        {
            StringBuilder sb = new StringBuilder(line);

            string[] symbolsToReplace = { "-", ",", ".", "!", "?" };

            foreach (string symbol in symbolsToReplace)
            {
                sb.Replace(symbol, "@");
            }

            return sb.ToString();
        }
    }
}

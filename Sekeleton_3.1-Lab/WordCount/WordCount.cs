namespace WordCount
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    public class WordCount
    {
        static void Main()
        {
            string wordPath = @"..\..\..\Files\words.txt";
            string textPath = @"..\..\..\Files\text.txt";
            string outputPath = @"..\..\..\Files\output.txt";

            CalculateWordCounts(wordPath, textPath, outputPath);
        }

        public static void CalculateWordCounts(string wordsFilePath, string textFilePath, string outputFilePath)
        {
            SortedDictionary<string, int> dictionary = new SortedDictionary<string, int>();

            string inputWords = File.ReadAllText(wordsFilePath);

            string[] words = inputWords
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            using StreamWriter writer = new StreamWriter(outputFilePath);
            {
                using (StreamReader reader = new StreamReader(textFilePath))
                {
                    string currentLine = reader.ReadLine();

                    while (currentLine != null)
                    {
                        foreach (string word in words)
                        {
                            if (currentLine.ToLower().Contains(word))
                            {
                                if (!dictionary.ContainsKey(word))
                                {
                                    dictionary.Add(word, 0);
                                }

                                dictionary[word]++;
                            }
                        }

                        currentLine = reader.ReadLine();
                    }

                    foreach (var word in dictionary.OrderByDescending(x => x.Value))
                    {
                        writer.WriteLine($"{word.Key} - {word.Value}");
                    }
                }
            }
        }
    }
}

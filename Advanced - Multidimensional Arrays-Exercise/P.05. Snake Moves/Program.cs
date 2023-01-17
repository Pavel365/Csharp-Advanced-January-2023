using System;
using System.Linq;

namespace P._05._Snake_Moves
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dimentions = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string word = Console.ReadLine();

            char[,] matrix = new char[dimentions[0], dimentions[1]];

            int currWordIndex = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                if (row % 2 ==0)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        if (currWordIndex == word.Length)
                        {
                            currWordIndex = 0;
                        }

                        matrix [row, col] = word [currWordIndex];

                        currWordIndex++;
                    }
                }
                else if (row % 2 == 1)
                {
                    for (int col = matrix.GetLength(1) - 1; col >= 0; col--)
                    {
                        if (currWordIndex == word.Length)
                        {
                            currWordIndex = 0;
                        }

                        matrix[row, col] = word[currWordIndex];

                        currWordIndex++;
                    }
                }
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }

                Console.WriteLine();
            }
        }
    }
}

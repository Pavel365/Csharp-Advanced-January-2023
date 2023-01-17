using System;
using System.Linq;

namespace P._10._RadioactMutVampBun
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dimentions = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rows = dimentions[0];
            int cols = dimentions[1];

            char[,] matrix = new char[rows, cols];

            int playerRow = 0;
            int playerCol = 0;  

            for (int row = 0; row < rows; row++)
            {
                string rowData = Console.ReadLine();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = rowData[col];

                    if (rowData[col] == 'P')
                    {
                        playerCol = col;
                        playerRow = row;
                        matrix[playerRow, playerCol] = '.';
                    } 
                }

            }

            string directions = Console.ReadLine();

            foreach (char direction in directions)
            {
                int oldPlayerRow = playerRow;
                int oldPlayerCol = playerCol;
                switch (direction)
                {
                    case 'L':playerCol--;
                        break;
                    case 'R':playerCol++;
                        break;
                    case 'U':playerRow--;
                        break;
                    case 'D':playerRow++;
                        break;
                }

                matrix = SpredBunnies(rows,cols,matrix);

                if (playerRow < 0 || playerRow >= rows || playerCol < 0 || playerCol >= cols)
                {
                    PrintResult(oldPlayerRow, oldPlayerCol, rows, cols, matrix, "won");
                    break;
                }

                if (matrix[playerRow, playerCol] == 'B')
                {
                    PrintResult(playerRow, playerCol, rows, cols, matrix, "dead");
                    break;
                }
            }
        }

        static char[,] SpredBunnies(int rows, int cols, char[,] matrix)
        {
            char[,] newMatrix = new char[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    newMatrix[row,col] = matrix[row,col];
                }
            }

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (matrix[row, col] == 'B')
                    {
                        if (row > 0)
                        {
                            newMatrix[row - 1, col] = 'B';
                        }
                        if (row < rows - 1)
                        {
                            newMatrix[row + 1, col] = 'B';
                        }
                        if (col > 0)
                        {
                            newMatrix[row, col - 1] = 'B';
                        }
                        if (col < cols - 1)
                        {
                            newMatrix[row, col + 1] = 'B';
                        }
                    }
                }
            }

            return newMatrix;
        }

        static void PrintResult(int playerRow, int playerCol, int rows, int cols, char[,] matrix, string result)
        {
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }

            Console.WriteLine($"{result}: {playerRow} {playerCol}");
        }
    }
}

using System;
using System.Linq;

namespace Rally_Racing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            string carNumber = Console.ReadLine();

            string[,] matrix = new string[size, size];

            bool isFirstTunnelFound = false;
            int firstTunnelRow = 0;
            int firstTunnelCol = 0;

            int secondTunnelRow = 0;
            int secondTunnelCol = 0;

            for (int row = 0; row < size; row++)
            {
                string[] rowData = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                for (int col = 0; col < size; col++)
                {
                    if (rowData[col] == "T" && !isFirstTunnelFound)
                    {
                        firstTunnelRow = row;
                        firstTunnelCol = col;
                        isFirstTunnelFound = true;
                    }
                    else if(rowData[col] == "T")
                    {
                        secondTunnelRow = row;
                        secondTunnelCol = col;
                    }
                    matrix[row, col] = rowData[col];
                }
            }

            int carRow = 0;
            int carCol = 0;
            int km = 0;
            bool isFinished = false;

            string command;
            while ((command = Console.ReadLine().ToLower()) != "end")
            {
                if (command == "down")
                {
                    carRow++;
                }
                if (command == "up")
                {
                    carRow--;
                }
                if (command == "right")
                {
                    carCol++;
                }
                if (command == "left")
                {
                    carCol--;
                }

                if (matrix[carRow, carCol] == ".")
                {
                    km += 10;
                }
                if (matrix[carRow, carCol] == "T")
                {
                    matrix[carRow, carCol] = ".";

                    if (carRow == firstTunnelRow && carCol == firstTunnelCol)
                    {
                        carRow = secondTunnelRow;
                        carCol = secondTunnelCol;
                    }
                    else
                    {
                        carRow = firstTunnelRow;
                        carCol = firstTunnelCol;
                    }

                    matrix[carRow, carCol] = ".";

                    km += 30;
                }
                if (matrix[carRow, carCol] == "F")
                {
                    km += 10;
                    isFinished = true;
                    break;
                }
            }

            matrix[carRow, carCol] = "C";

            if (isFinished)
            {
                Console.WriteLine($"Racing car {carNumber} finished the stage!");
            }
            else
            {
                Console.WriteLine($"Racing car {carNumber} DNF.");
            }

            Console.WriteLine($"Distance covered {km} km.");

            PrintMatrix(matrix);
        }

        static void PrintMatrix<T>(T[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row,col]);
                }

                Console.WriteLine();
            }
        }
    }
}

using System;
using System.Linq;

namespace NavyBattle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            char[,] battlefield = new char[size, size];

            int submarineRow = -1;
            int submarineCol = -1;

            for (int row = 0; row < size; row++)
            {
                string rowInput = Console.ReadLine();

                for (int col = 0; col < size; col++)
                {
                    battlefield[row, col] = rowInput[col];

                    if (battlefield[row, col] == 'S')
                    {
                        submarineRow = row;
                        submarineCol = col;
                    }
                }
            }

            int enemyCruisers = 3;
            int minesCount = 0;

            while (true)
            {
                battlefield[submarineRow, submarineCol] = '-';

                string command = Console.ReadLine();

                if (command == "right")
                {
                    submarineCol++;
                }
                if (command == "left")
                {
                    submarineCol--;
                }
                if (command == "down")
                {
                    submarineRow++;
                }
                if (command == "up")
                {
                    submarineRow--;
                }

                if (battlefield[submarineRow, submarineCol] == 'C')
                {
                    enemyCruisers--;
                }
                else if (battlefield[submarineRow, submarineCol] == '*')
                {
                    minesCount++;
                }

                if (enemyCruisers == 0)
                {
                    Console.WriteLine("Mission accomplished, U-9 has " +
                        "destroyed all battle cruisers of the enemy!");
                    break;
                }

                if (minesCount == 3)
                {
                    Console.WriteLine($"Mission failed, U-9 disappeared! " +
                        $"Last known coordinates [{submarineRow}, {submarineCol}]!");
                    break;
                }
            }

            battlefield[submarineRow, submarineCol] = 'S';

            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    Console.Write(battlefield[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}

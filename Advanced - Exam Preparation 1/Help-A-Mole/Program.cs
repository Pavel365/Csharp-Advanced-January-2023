using System;

namespace Help_A_Mole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            char[,] plaingField = new char[size, size];

            int molRow = 0;
            int molCol = 0;

            int specialLocatonRow = 0;
            int specialLocationCol = 0;
            bool isFirstLooked = false;

            int specialLocatonRow1 = 0;
            int specialLocationCol1 = 0;

            for (int row = 0; row < size; row++)
            {
                string rowInput = Console.ReadLine();

                for (int col = 0; col < size; col++)
                {
                    plaingField[row, col] = rowInput[col];

                    if (plaingField[row, col] == 'M')
                    {
                        molRow = row;
                        molCol = col;
                    }

                    if (plaingField[row, col] == 'S' && isFirstLooked == false)
                    {
                        specialLocatonRow = row;
                        specialLocationCol = col;
                        isFirstLooked = true;
                    }
                    if(plaingField[row, col] == 'S' && isFirstLooked)
                    {
                        specialLocatonRow1 = row;
                        specialLocationCol1 = col;
                    }
                }
            }

            int pointsEned = 0;
            plaingField[molRow, molCol] = '-';

            string command;
            while ((command = Console.ReadLine()) != "End" && pointsEned < 25)
            {
                int molRow1 = molRow;
                int molCol1 = molCol;    

                if (command == "right")
                {
                    molCol1++;
                    if (IsInMatrix(molRow1, molCol1, plaingField))
                    {
                        molCol++;
                    }
                    else
                    {
                        Console.WriteLine("Don't try to escape the playing field!");
                        continue;
                    }
                }
                if (command == "left")
                {
                    molCol1--;
                    if (IsInMatrix(molRow1, molCol1, plaingField))
                    {
                        molCol--;
                    }
                    else
                    {
                        Console.WriteLine("Don't try to escape the playing field!");
                        continue;
                    }
                }
                if (command == "down")
                {
                    molRow1++;
                    if (IsInMatrix(molRow1, molCol1, plaingField))
                    {
                        molRow++;
                    }
                    else
                    {
                        Console.WriteLine("Don't try to escape the playing field!");
                        continue;
                    }
                }
                if (command == "up")
                {
                    molRow1--;
                    if (IsInMatrix(molRow1, molCol1, plaingField))
                    {
                        molRow--;
                    }
                    else
                    {
                        Console.WriteLine("Don't try to escape the playing field!");
                        continue;
                    }
                    
                }

                if (char.IsDigit(plaingField[molRow,molCol]))
                {
                    string digit = Convert.ToString(plaingField[molRow,molCol]);
                    pointsEned += int.Parse(digit);
                    plaingField[molRow,molCol] = '-';
                }

                if (plaingField[molRow, molCol] == 'S')
                {
                    if (molRow == specialLocatonRow && molCol == specialLocationCol)
                    {
                        plaingField[molRow, molCol] = '-';
                        molRow = specialLocatonRow1;
                        molCol = specialLocationCol1;
                    }
                    else if (molRow == specialLocatonRow1 && molCol == specialLocationCol1)
                    {
                        plaingField[molRow, molCol] = '-';
                        molRow = specialLocatonRow;
                        molCol = specialLocationCol;
                    }
                    pointsEned -= 3;
                }
                
                plaingField[molRow, molCol] = '-'; 
            }

            plaingField[molRow, molCol] = 'M';

            if (pointsEned >= 25)
            {
                Console.WriteLine("Yay! The Mole survived another game!");
                Console.WriteLine($"The Mole managed to survive with a total " +
                    $"of {pointsEned} points.");
            }
            else
            {
                Console.WriteLine("Too bad! The Mole lost this battle!");
                Console.WriteLine($"The Mole lost the game with a total " +
                    $"of {pointsEned} points.");
            }

            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    Console.Write(plaingField[row, col]);
                }
                Console.WriteLine();
            }
        }

        static bool IsInMatrix(int row, int col, char[,] matrix)
        {
            return row >= 0 && col >= 0 &&
                row < matrix.GetLength(0) && col < matrix.GetLength(1);
        }
    }
}

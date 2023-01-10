using System;
using System.Collections.Generic;

namespace P._04._Matching_Brackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string expression = Console.ReadLine();

            Stack<int> openBracketsIndexes = new Stack<int>();

            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '(')
                {
                    openBracketsIndexes.Push(i);
                }
                else if (expression[i] == ')')
                {
                    int openBrackets = openBracketsIndexes.Pop();

                    for (int j = openBrackets; j <= i; j++)
                    {
                        Console.Write(expression[j]);
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}

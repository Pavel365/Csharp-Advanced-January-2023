using System;
using System.Collections.Generic;

namespace P._08._Balanced_Parenthesis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string parenthesis = Console.ReadLine();

            Stack<char> stack = new Stack<char>();

            foreach (char parenthese in parenthesis)
            {
                if (parenthese == '(' || parenthese == '[' || parenthese == '{')
                {
                    stack.Push(parenthese);
                }
                else if (parenthese == ')')
                {
                    if (stack.Count == 0 || stack.Pop() != '(')
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                }
                else if (parenthese == ']')
                {
                    if (stack.Count == 0 || stack.Pop() != '[')
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                }
                else if (parenthese == '}')
                {
                    if (stack.Count == 0 || stack.Pop() != '{')
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                }
            }

            if (stack.Count > 0)
            {
                Console.WriteLine("NO");
            }
            else
            {
                Console.WriteLine("YES");
            }
            
        }
    }
}

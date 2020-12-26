using System;
using System.Collections;
using System.Collections.Generic;

namespace Matching_Brackets
{
    class Program
    {
        private static object stack;

        static void Main(string[] args)
        {
            string expression = Console.ReadLine();

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < expression.Length; i++)
            {
                if(expression[i] == '(')
                {
                    stack.Push(i);
                }
                else if(expression[i] == ')')
                {
                    int start = stack.Pop();
                    string result = expression.Substring(start, i - start + 1);
                    Console.WriteLine(result);
                }
                
            }
            
        }
    }
}

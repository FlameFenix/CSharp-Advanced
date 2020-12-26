using System;
using System.Collections.Generic;

namespace Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<char> reverse = new Stack<char>();

            for (int i = 0; i < input.Length; i++)
            {
                reverse.Push(input[i]);
            }

            print(reverse);
        }

        public static void print(Stack<char> reverse)
        {
            foreach (var item in reverse)
            {
                Console.Write(item);
            }
        }
    }
}

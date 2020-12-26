using System;
using System.Collections.Generic;
using System.Linq;

namespace Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] numbers = Console.ReadLine()
                                      .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                      .Reverse()
                                      .ToArray();

            Stack<string> sum = new Stack<string>(numbers);

            while (sum.Count != 1)
            {
                int numberOne = int.Parse(sum.Pop());
                string separator = sum.Pop();
                int numberTwo = int.Parse(sum.Pop());
                if(separator == "+")
                {
                    string sumNumbers = (numberOne + numberTwo).ToString();
                    sum.Push(sumNumbers);
                }
                else if(separator == "-")
                {
                    string sumNumbers = (numberOne - numberTwo).ToString();
                    sum.Push(sumNumbers);
                }
                
            }

            foreach (var item in sum)
            {
                Console.WriteLine(item);
            }
        }
    }
}

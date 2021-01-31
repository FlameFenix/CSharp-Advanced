using System;
using System.Collections.Generic;
using System.IO;

namespace Merge_Files
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader inputOne = new StreamReader("../../../input1.txt");

            StreamReader inputTwo = new StreamReader("../../../input2.txt");

            using(inputOne)
            {
                using(inputTwo)
                {
                    List<int> numbers = new List<int>();

                    string firstLine = inputOne.ReadLine();
                    string secondLine = inputTwo.ReadLine();

                    while (firstLine != null && secondLine != null)
                    {
                        if (firstLine != null)
                        {
                            numbers.Add(int.Parse(firstLine));
                            firstLine = inputOne.ReadLine();
                        }
                        if (secondLine != null)
                        {
                            numbers.Add(int.Parse(secondLine));
                            secondLine = inputTwo.ReadLine();
                        }
                    }

                    StreamWriter writer = new StreamWriter("../../../output.txt");

                    using (writer)
                    {
                        foreach (var item in numbers)
                        {
                            writer.WriteLine(item);
                        }
                    }
                }
            }
        }
    }
}

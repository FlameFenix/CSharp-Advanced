using System;
using System.IO;

namespace Line_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string pathInput = "../../../input.txt";
            string pathOutput = "../../../output.txt";
            StreamReader reader = new StreamReader(pathInput);

            string currentLine = reader.ReadLine();

            int counter = 1;
                using (StreamWriter writer = new StreamWriter(pathOutput))
                {
                while (currentLine != null)
                {
                    writer.WriteLine($"{counter}. {currentLine}");
                    currentLine = reader.ReadLine();
                    counter++;
                }
            }
        }
    }
}

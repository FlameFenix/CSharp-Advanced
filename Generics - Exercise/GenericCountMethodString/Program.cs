using System;

namespace GenericCountMethodString
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfOperations = int.Parse(Console.ReadLine());

            Box<string> newBox = new Box<string>();
            
            for (int i = 0; i < numberOfOperations; i++)
            {
                string element = Console.ReadLine();

                newBox.Add(element);
            }

            string comparableElement = Console.ReadLine();

            Console.WriteLine(newBox.CompareByValue(comparableElement));
        }
    }
}

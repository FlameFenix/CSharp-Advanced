using System;

namespace GenericCountMethodDouble
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfOperations = int.Parse(Console.ReadLine());

            Box<double> newBox = new Box<double>();

            for (int i = 0; i < numberOfOperations; i++)
            {
                double element = double.Parse(Console.ReadLine());

                newBox.Add(element);
            }

            double comparableElement = double.Parse(Console.ReadLine());

            Console.WriteLine(newBox.CompareByValue(comparableElement));
        }
    }
}

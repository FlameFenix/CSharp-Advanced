using System;

namespace GenericBoxOfInteger
{
    public class Program
    {
        static void Main(string[] args)
        {
            Box<int> box = new Box<int>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int currentLine = int.Parse(Console.ReadLine());

                box.Add(currentLine);
            }

            Console.WriteLine(box.ToString());
        }
    }
}

using System;
using System.Collections.Generic;

namespace Record_Unique_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfNames = int.Parse(Console.ReadLine());

            HashSet<string> names = new HashSet<string>(numberOfNames);

            for (int i = 0; i < numberOfNames; i++)
            {
                string name = Console.ReadLine();

                names.Add(name);
            }

            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
        }
    }
}

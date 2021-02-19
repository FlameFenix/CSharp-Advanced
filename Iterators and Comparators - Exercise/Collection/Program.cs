using System;
using System.Collections.Generic;
using System.Linq;

namespace ListyIteratorTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = string.Empty;

            ListyIterator<string> listy = new ListyIterator<string>();

            while ((command = Console.ReadLine()) != "END")
            {
                string[] cmdArgs = command.Split().ToArray();

                switch (cmdArgs[0])
                {
                    case "Create":

                        List<string> items = cmdArgs.Skip(1).ToList();

                        listy.Create(items);

                        break;
                    case "Print":
                        listy.Print();
                        break;
                    case "HasNext":
                        Console.WriteLine(listy.HasNext());
                        break;
                    case "Move":
                        Console.WriteLine(listy.MoveNext());
                        break;
                    case "PrintAll":

                        foreach (var item in listy)
                        {
                            Console.Write($"{item} ");
                        }

                        Console.WriteLine();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace Predicate_Party_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = Console.ReadLine()
                                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                    .ToList();

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "Party!")
            {
                string[] cmdArgs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                          .ToArray();

                string currentCommand = cmdArgs[0];

                string secondCommand = cmdArgs[1];

                if (currentCommand == "Remove")
                {

                    List<string> namesToRemove = new List<string>();

                    if (secondCommand == "Length")
                    {
                        int length = int.Parse(cmdArgs[2]);

                        namesToRemove = names.Where(x => x.Length == length).ToList();

                        NamesToRemove(names, namesToRemove);
                    }
                    else if (secondCommand == "StartsWith")
                    {
                        string startString = cmdArgs[2];

                        namesToRemove = names.Where(x => x.StartsWith(startString)).ToList();

                        NamesToRemove(names, namesToRemove);

                    }
                    else if (secondCommand == "EndsWith")
                    {
                        string endString = cmdArgs[2];
                        names = names.Where(x => x.EndsWith(endString)).ToList();

                        namesToRemove = names.Where(x => x.EndsWith(endString)).ToList();

                        foreach (var name in namesToRemove)
                        {
                            NamesToRemove(names, namesToRemove);
                        }
                    }
                }
                else if (currentCommand == "Double")
                {
                    List<string> namesToDouble = new List<string>();

                    if (secondCommand == "Length")
                    {
                        int length = int.Parse(cmdArgs[2]);

                        namesToDouble = names.Where(x => x.Length == length).ToList();

                        AddNamesToList(names, namesToDouble);
                    }
                    else if (secondCommand == "StartsWith")
                    {
                        string startString = cmdArgs[2];

                        namesToDouble = names.Where(x => x.StartsWith(startString)).ToList();

                        AddNamesToList(names, namesToDouble);
                    }
                    else if (secondCommand == "EndsWith")
                    {
                        string endString = cmdArgs[2];

                        namesToDouble = names.Where(x => x.EndsWith(endString)).ToList();

                        AddNamesToList(names, namesToDouble);
                    }
                }
            }
            if (names.Count > 0)
            {
                Console.WriteLine($"{string.Join(", ", names)} are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }

        private static void NamesToRemove(List<string> names, List<string> namesToRemove)
        {
            for (int i = 0; i < namesToRemove.Count; i++)
            {
                names.Remove(namesToRemove[i]);
            }
        }

        private static void AddNamesToList(List<string> names, List<string> namesToDouble)
        {
            for (int i = 0; i < namesToDouble.Count; i++)
            {
                names.Insert(0, namesToDouble[i]);
            }
        }
    }
}

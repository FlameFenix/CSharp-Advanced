using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Songs_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] songs = Console.ReadLine()
                                    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                                    .ToArray();

            string command = string.Empty;

            Queue<string> songsList = new Queue<string>(songs);

            while (songsList.Count >= 0)
            {
                if (songsList.Count == 0)
                {
                    Console.WriteLine("No more songs!");
                    break;
                }

                command = Console.ReadLine();

                if (command == "Play")
                {
                    songsList.Dequeue();
                }
                else if (command == "Show")
                {
                    Console.WriteLine(string.Join(", ", songsList));
                }
                else
                {
                    string[] cmdArgs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                    if (cmdArgs[0] == "Add")
                    {
                        string currentSong = command.Substring(4, command.Length - 4);
                        if (songsList.Contains(currentSong))
                        {
                            Console.WriteLine($"{currentSong} is already contained!");
                        }
                        else
                        {
                            songsList.Enqueue(currentSong);
                        }

                    }
                }
            }
        }
    }
}

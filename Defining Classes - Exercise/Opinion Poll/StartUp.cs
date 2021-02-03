using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Person> listOfMembers = new List<Person>();

            for (int i = 0; i < n; i++)
            {
                string[] cmdArgs = Console.ReadLine()
                                          .Split()
                                          .ToArray();

                string name = cmdArgs[0];
                int age = int.Parse(cmdArgs[1]);

                Person newPerson = new Person(name, age);

                listOfMembers.Add(newPerson);
            }

            foreach (var item in listOfMembers.Where(x => x.Age > 30).OrderBy(x => x.Name))
            {
                Console.WriteLine($"{item.Name} - {item.Age}");
            }
        }
    }
}

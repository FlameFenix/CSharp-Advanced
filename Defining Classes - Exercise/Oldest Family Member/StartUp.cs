using System;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Family familyMembers = new Family();

            for (int i = 0; i < n; i++)
            {
                string[] cmdArgs = Console.ReadLine()
                                          .Split()
                                          .ToArray();

                string name = cmdArgs[0];
                int age = int.Parse(cmdArgs[1]);

                Person newFamilyMember = new Person(name, age);

                familyMembers.AddMember(newFamilyMember);

            }
            Console.WriteLine($"{familyMembers.GetOldestMember().Name} {familyMembers.GetOldestMember().Age}");
        }
    }
}

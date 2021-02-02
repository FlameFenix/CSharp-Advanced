using System;
using System.Collections.Generic;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Person Pesho = new Person();
            Person Gosho = new Person(18);
            Person Stamat = new Person("Stamat", 43);

            List<Person> listMembers = new List<Person>();

            listMembers.Add(Pesho);
            listMembers.Add(Gosho);
            listMembers.Add(Stamat);

            foreach (var item in listMembers)
            {
                Console.WriteLine($"Name: {item.Name} Age: {item.Age}");
            }
        }
    }
}

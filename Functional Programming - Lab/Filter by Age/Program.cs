using System;
using System.Collections.Generic;
using System.Linq;

namespace Filter_by_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Person> persons = new List<Person>();

            for (int i = 0; i < n; i++)
            {
                string[] info = Console.ReadLine()
                                       .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                                       .ToArray();
                string name = info[0];
                int age = int.Parse(info[1]);

                Person currentPerson = new Person(name, age);

                persons.Add(currentPerson);

            }

            string condition = Console.ReadLine();

            int ageCondition = int.Parse(Console.ReadLine());

            string format = Console.ReadLine();
            Print(condition, format,ageCondition, persons);

        }

        private static void Print(string condition, string format, int ageCondintion, List<Person> persons)
        {
            if(format == "name")
            {
                if(condition == "younger")
                {
                    foreach (var item in persons.Where(x => x.Age < ageCondintion))
                    {
                        Console.WriteLine(item.Name);
                    }
                }
                else if(condition == "older")
                {
                    foreach (var item in persons.Where(x => x.Age >= ageCondintion))
                    {
                        Console.WriteLine(item.Name);
                    }
                }
            }
            else if (format == "age")
            {
                if (condition == "younger")
                {
                    foreach (var item in persons.Where(x => x.Age < ageCondintion))
                    {
                        Console.WriteLine(item.Age);
                    }
                }
                else if(condition == "older")
                {
                    foreach (var item in persons.Where(x => x.Age >= ageCondintion))
                    {
                        Console.WriteLine(item.Age);
                    }

                }
            }
            else if (format == "name age")
            {
                if(condition == "younger")
                {
                    foreach (var item in persons.Where(x => x.Age < ageCondintion))
                    {
                        Console.WriteLine($"{item.Name} - {item.Age}");
                    }
                }
                else if(condition == "older")
                {
                    foreach (var item in persons.Where(x => x.Age >= ageCondintion))
                    {
                        Console.WriteLine($"{item.Name} - {item.Age}");
                    }
                }
            }
        }
    }

    class Person
    {
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}

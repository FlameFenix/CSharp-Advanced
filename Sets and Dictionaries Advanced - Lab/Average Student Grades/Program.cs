using System;
using System.Collections.Generic;
using System.Linq;

namespace Average_Student_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfStudents = int.Parse(Console.ReadLine());

            Dictionary<string, List<decimal>> studentsGrade = new Dictionary<string, List<decimal>>();

            for (int i = 0; i < numberOfStudents; i++)
            {
                string[] studentInfo = Console.ReadLine()
                                              .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                                              .ToArray();
                string name = studentInfo[0];
                decimal grade = decimal.Parse(studentInfo[1]);

                if (!studentsGrade.ContainsKey(name))
                {
                    studentsGrade.Add(name, new List<decimal>());
                }

                studentsGrade[name].Add(grade);

            }

            foreach (var item in studentsGrade)
            {
                Console.WriteLine($"{item.Key} -> {string.Join(" ", item.Value.Select(x => string.Format("{0:f2}", x)))} (avg: {item.Value.Average():f2})");
            }
        }
    }
}

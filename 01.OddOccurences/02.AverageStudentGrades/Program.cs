using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.AverageStudentGrades
{
    class Program
    {
        static void Main()
        {
            var grades = new Dictionary<string, List<double>>();
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var tokens = Console.ReadLine().Split();
                var name = tokens[0];
                var grade = double.Parse(tokens[1]);
                if (!grades.ContainsKey(name))
                {
                    grades[name] = new List<double>();
                    
                }
                grades[name].Add(grade);
            }
            foreach (var pair in grades)
            {
                var name = pair.Key;
                var studentsGrades = pair.Value;
                var average = studentsGrades.Average(); //average value of the list

                Console.Write($"{name} -> ");

                foreach (var grade in studentsGrades)
                {
                    Console.Write($"{grade:f2} ");
                    
                }
                Console.WriteLine($"(avg: {average:f2})");
            }
        }
    }
}

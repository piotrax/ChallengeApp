using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeApp
{
    public class Employee
    {
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int Age { get; set; }
        public List<float> grades = new List<float>();

        public Employee(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public void AddFloatGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                Console.WriteLine("Invalid grade data!");
            }
        }

        public void AddGrade(string grade)
        {
            try
            {
                var values = new Dictionary<string, float>()
                {
                    { "A", 100 }, { "a", 100 }, { "B", 80 }, { "b", 80 },
                    { "C", 60 }, { "c", 60 }, { "D", 40 }, { "d", 40 },
                    { "E", 20 }, { "e", 20 }
                };

                if (values.ContainsKey(grade))
                {
                    this.grades.Add(values[grade]);
                }
                else
                {
                    this.AddFloatGrade(float.Parse(grade));
                }
            }
            catch
            {
                Console.WriteLine("Input error!");
            }
            
        }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach(var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }
            statistics.Average /= this.grades.Count;


            switch (statistics.Average)
            {
                case var average when average >= 80:
                    statistics.AverageLetter = 'A';
                    break;
                case var average when average >= 60:
                    statistics.AverageLetter = 'B';
                    break;
                case var average when average >= 40:
                    statistics.AverageLetter = 'C';
                    break;
                case var average when average >= 20:
                    statistics.AverageLetter = 'D';
                    break;
                default:
                    statistics.AverageLetter = 'E';
                    break;
            }

            return statistics;
        }

    }
}

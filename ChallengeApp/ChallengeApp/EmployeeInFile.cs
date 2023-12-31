﻿using System.Diagnostics;

namespace ChallengeApp
{
    public class EmployeeInFile : EmployeeBase
    {
        private const string fileName = "grades.txt";
        public override event GradeAddedDelegate GradeAdded;
        public EmployeeInFile(string name, string surname) 
            : base(name, surname)
        {
        }
        public override void EmployeeGradeAdded(object sender, EventArgs args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Dodano nową ocenę");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public override void AddGrade(float grade)
        {
            using (var writer = File.AppendText(fileName))
            {
                if (grade >= 0 && grade <= 100)
                    writer.WriteLine(grade);
                if (GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
                else 
                    throw new Exception("Invalid grade data!");
            }
        }

        public override void AddGrade(double grade)
        {
            using (var writer = File.AppendText(fileName))
            {
                if (grade >= 0 && grade <= 100)
                    writer.WriteLine((float)grade);
                if (GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
                else
                    throw new Exception("Invalid grade data!");
            }
        }

        public override void AddGrade(int grade)
        {
            using (var writer = File.AppendText(fileName))
            {
                if (grade >= 0 && grade <= 100)
                    writer.WriteLine((float)grade);
                if (GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
                else
                    throw new Exception("Invalid grade data!");
            }
        }

        public override void AddGrade(char grade)
        {
            Dictionary<char, int> mapGrades = new Dictionary<char, int>()
            {
                {'A', 100}, {'B', 80}, {'C', 60}, {'D', 40}, {'E', 20}, {'F', 0},
                {'a', 100}, {'b', 80}, {'c', 60}, {'d', 40}, {'e', 20}, {'f', 0}
            };
            try
            {
                using (var writer = File.AppendText(fileName))
                {
                    writer.WriteLine(mapGrades[grade]);
                    if (GradeAdded != null)
                    {
                        GradeAdded(this, new EventArgs());
                    }
                }
            }
            catch(Exception ex)
            {
                throw new Exception($"Input error! {ex.Message}");
            }
        }

        public override void AddGrade(string grade)
        {
            Dictionary<string, int> mapGrades = new Dictionary<string, int>()
            {
                {"A", 100}, {"B", 80}, {"C", 60}, {"D", 40}, {"E", 20}, {"F", 0},
                {"a", 100}, {"b", 80}, {"c", 60}, {"d", 40}, {"e", 20}, {"f", 0}
            };
            try
            {
                using (var writer = File.AppendText(fileName))
                {
                    writer.WriteLine(mapGrades[grade]);
                    if (GradeAdded != null)
                    {
                        GradeAdded(this, new EventArgs());
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Input error! {ex.Message}");
            }
        }

        public override Statistics GetStatistics()
        {
            var statistics = new Statistics();
            List<float> grades = new List<float>();
            if (File.Exists(fileName))
            {
                using (var reader = File.OpenText(fileName))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        Console.Write($"{line} ");
                        var number = float.Parse(line);
                        grades.Add(number);
                        statistics.AddGrade(number);
                        line = reader.ReadLine();
                    }
                    Console.WriteLine();
                }
            }
            return statistics;
        }
    }
}

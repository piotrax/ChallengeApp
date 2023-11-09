using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeApp
{
    public class Employee : IEmployee
    {
        public List<float> grades = new List<float>();
        public int Age { get; private set; }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public string Gender { get; private set; }
        public Employee(string name, string surname, string gender)
        {
            this.Name = name;
            this.Surname = surname;
            this.Gender = gender;
        }

        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                throw new Exception("Invalid grade data!");
            }
        }

        public void AddGrade(double grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add((float)grade);
            }
            else
            {
                throw new Exception("Invalid grade data!");
            }
        }

        public void AddGrade(int grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                throw new Exception("Invalid grade data!");
            }
        }

        public void AddGrade(char grade)
        {
            Dictionary<char, int> mapGrades = new Dictionary<char, int>()
            {
                {'A', 100}, {'B', 80}, {'C', 60}, {'D', 40}, {'E', 20}, {'F', 0},
                {'a', 100}, {'b', 80}, {'c', 60}, {'d', 40}, {'e', 20}, {'f', 0}
            };

            try
            {
                grades.Add(mapGrades[grade]);
            }

            catch (Exception e)
            {
                throw new Exception($"Input error! {e.Message}");
            }
        }

        public void AddGrade(string grade)
        {
            Dictionary<string, int> mapGrades = new Dictionary<string, int>()
            {
                {"A", 100}, {"B", 80}, {"C", 60}, {"D", 40}, {"E", 20}, {"F", 0},
                {"a", 100}, {"b", 80}, {"c", 60}, {"d", 40}, {"e", 20}, {"f", 0}
            };

            try
            {
                grades.Add(mapGrades[grade]);
            }

            catch
            {
                try
                {
                    this.AddGrade(float.Parse(grade));
                }
                catch (Exception e)
                {
                    throw new Exception($"Input error! {e.Message}");
                }
            }
        }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            foreach (var grade in grades)
            {
                statistics.AddGrade(grade);
            }
            return statistics;
        }

    }
}

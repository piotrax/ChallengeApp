﻿using System;
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
        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else{
                Console.WriteLine("Invalid grade data!");
            }
        }

        public void AddGrade(byte grade)
        {
            var value = (float)grade;
            this.AddGrade(value);
   
        }

        public void AddGrade(long grade)
        {
            var value = (float)grade;
            this.AddGrade(value);

        }

        public void AddGrade(double grade)
        {
            var value = (float)grade;
            this.AddGrade(value);

        }

        public void AddGrade(string grade)
        {
            if(float.TryParse(grade, out float value))
            {
                // var value = float.Parse(grade);
                this.AddGrade(value);
            }
            else
            {
                Console.WriteLine("String is not float!");
            }
        }
        public float GetGrade() { return this.grades.Sum(); }

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
            return statistics;
        }

        public Statistics GetStatisticsWithForEach()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }
            statistics.Average /= this.grades.Count;
            return statistics;
        }

        public Statistics GetStatisticsWithFor()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            for (int grade = 0; grade < this.grades.Count; grade++)
            {
                statistics.Max = Math.Max(statistics.Max, this.grades[grade]);
                statistics.Min = Math.Min(statistics.Min, this.grades[grade]);
                statistics.Average += this.grades[grade];
            }
            statistics.Average /= this.grades.Count;
            return statistics;
        }

        public Statistics GetStatisticsWithDoWhile()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            int grade = 0;
            do
            {
                statistics.Max = Math.Max(statistics.Max, this.grades[grade]);
                statistics.Min = Math.Min(statistics.Min, this.grades[grade]);
                statistics.Average += this.grades[grade];
                grade++;
            }while (grade < this.grades.Count);
            statistics.Average /= this.grades.Count;
            return statistics;
        }

        public Statistics GetStatisticsWithWhile()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;
            int grade = 0;
            while (grade < this.grades.Count)
            {
                statistics.Max = Math.Max(statistics.Max, this.grades[grade]);
                statistics.Min = Math.Min(statistics.Min, this.grades[grade]);
                statistics.Average += this.grades[grade];
                grade++;
            }
            statistics.Average /= this.grades.Count;
            return statistics;
        }
    }
}

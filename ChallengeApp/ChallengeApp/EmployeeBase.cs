using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeApp
{
    public abstract class EmployeeBase : IEmployee
    {
        public int Age => throw new NotImplementedException();

        public string Name {  get; private set; }

        public string Surname { get; private set; }

        public string Gender => throw new NotImplementedException();

        public abstract void AddGrade(float grade);
        public abstract void AddGrade(double grade);

        public abstract void AddGrade(int grade);

        public abstract void AddGrade(char grade);

        public abstract void AddGrade(string grade);

        public abstract Statistics GetStatistics();

        public EmployeeBase(string name, string surname) 
        {
            this.Name = name;
            this.Surname = surname;
        }
    }
}

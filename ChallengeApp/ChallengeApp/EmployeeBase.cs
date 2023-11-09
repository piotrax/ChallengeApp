namespace ChallengeApp
{
    public abstract class EmployeeBase : IEmployee
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Gender { get; set; }
        public abstract void AddGrade(float grade);
        public abstract void AddGrade(double grade);
        public abstract void AddGrade(int grade);
        public abstract void AddGrade(char grade);
        public abstract void AddGrade(string grade);
        public abstract Statistics GetStatistics();

        public delegate void GradeAddedDelegate(object sender, EventArgs args);
        
        public abstract event GradeAddedDelegate GradeAdded;

        public abstract void EmployeeGradeAdded(object sender, EventArgs args);
        public EmployeeBase(string name, string surname) 
        {
            this.Name = name;
            this.Surname = surname;
        }
    }
}

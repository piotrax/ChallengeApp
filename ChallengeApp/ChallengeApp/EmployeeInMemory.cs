namespace ChallengeApp
{
    public class EmployeeInMemory : EmployeeBase
    {
        public List<float> grades = new List<float>();
        public int Age { get; private set; }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public string Gender { get; private set; }

        public override event GradeAddedDelegate GradeAdded;
        public EmployeeInMemory(string name, string surname) 
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
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
                if (GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
            }
            else
            {
                throw new Exception("Invalid grade data!");
            }
        }

        public override void AddGrade(double grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add((float)grade);
                if (GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
            }
            else
            {
                throw new Exception("Invalid grade data!");
            }
        }

        public override void AddGrade(int grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
                if (GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
            }
            else
            {
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
                grades.Add(mapGrades[grade]);
                if (GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
            }

            catch (Exception e)
            {
                throw new Exception($"Input error! {e.Message}");
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
                grades.Add(mapGrades[grade]);
                if(GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
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

        public override Statistics GetStatistics()
        {
            var statistics = new Statistics();
            foreach(var grade in grades)
            {
                statistics.AddGrade(grade);
            }
            return statistics;
        }
    }
}

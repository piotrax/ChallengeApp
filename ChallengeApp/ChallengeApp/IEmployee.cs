namespace ChallengeApp
{
    public interface IEmployee
    {
        int Age { get; }
        string Name { get; }
        string Surname { get; }
        string Gender { get; }

        void AddGrade(float grade);
        void AddGrade(double grade);
        void AddGrade(int grade);
        void AddGrade(char grade);
        void AddGrade(string grade);

        //event GradeAddedDelegate GradeAdded;
        Statistics GetStatistics();
    }
}

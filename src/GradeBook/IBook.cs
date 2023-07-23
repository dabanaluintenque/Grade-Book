namespace GradeBook {
    public interface IBook {
        void AddGrade(double grae);
        Statistics GetStatistics();
        string Name { get; }
        event GradeAddedDelegate GradeAdded;
    }
}
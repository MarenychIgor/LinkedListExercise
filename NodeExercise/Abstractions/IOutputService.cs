namespace NodeExercise.Abstractions
{
    public interface IOutputService
    {
        void Print(string message, bool newLine = true);
        void PrintWithChildren(Node node);
    }
}

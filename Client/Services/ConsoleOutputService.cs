using NodeExercise;
using NodeExercise.Abstractions;
using System;

namespace ConsoleApp3.Services
{
    public class ConsoleOutputService : IOutputService
    {
        public void Print(string message, bool newLine = true)
        {
            if (newLine) Console.WriteLine(message);
            else Console.Write(message);
        }
        
        public void PrintWithChildren(Node node)
        {
            while (node != default)
            {
                Print($"Current {node.Index} next {node.Next?.Index ?? default}");
                node = node.Next;
            }
        }
    }
}

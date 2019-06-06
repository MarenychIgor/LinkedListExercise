using ConsoleApp3.Services;
using NodeExercise;
using NodeExercise.Abstractions;
using SimpleInjector;
using System;

namespace Client
{
    class Program
    {
        private static readonly Container container;

        static Program()
        {
            container = new Container();

            container.Register<IInputService, ConsoleInputService>();
            container.Register<IOutputService, ConsoleOutputService>();

            container.Verify();
        }

        static void Main(string[] args)
        {
            var inputService = container.GetInstance<IInputService>();
            var outputService = container.GetInstance<IOutputService>();

            var childCount = inputService.GetInput();
            var recursive = new Node(childCount);
            var iterative = new Node(childCount);

            Console.WriteLine("Recursive");
            outputService.PrintWithChildren(recursive.GetReversedRecursive());
            Console.WriteLine("Iterative");
            outputService.PrintWithChildren(iterative.GetReversedIterative());
        }
    }
}

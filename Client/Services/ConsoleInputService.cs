using NodeExercise.Abstractions;
using System;

namespace ConsoleApp3.Services
{
    public class ConsoleInputService : IInputService
    {
        private readonly IOutputService _outputService;

        public ConsoleInputService(IOutputService outputService)
          => _outputService = outputService;

        public int GetInput()
        {
            _outputService.Print("Please, fill any number ", newLine: false);
            if (int.TryParse(Console.ReadLine(), out var result) && result > 0)
                return result;

            _outputService.Print("Input must be a number that greater than 0");
            return GetInput();
        }
    }
}

using System;
using TaskManagerCLI.Entities;

namespace TaskManagerCLI
{
    internal class Program {
        static void Main(string[] args) {
            var taskManager = new TaskManager();

            /* The args array will store the user's input in the command line, separating the words and reseting with each new command.
             * The command "add" takes de position [0] and the description the position [1]. We pass it as an argument to the "AddTask" method. */
            if (args.Length == 0) {
                Console.WriteLine("Please provide a command.");
                return;
            }

            string command = args[0];
            switch (command.ToLower()) {
                case "add":
                    if (args.Length < 2) {
                        Console.WriteLine("Please provide a description for the task.");
                        return;
                    }
                    taskManager.AddTask(args[1]);
                    break;

                default:
                    Console.WriteLine("Invalid command.");
                    break;
            }            
        }
    }
}
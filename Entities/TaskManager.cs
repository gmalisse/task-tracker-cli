using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Xml;

namespace TaskManagerCLI.Entities {
    internal class TaskManager {
        private List<Task> tasks;
        private const string FilePath = "tasks.json";
        int newId;

        public TaskManager() {
            tasks = LoadTasks();
        }

        /* Reads the content of the file and stores in a string variable. The last method
         * converts the string in a list of Task objects. */
        private List<Task> LoadTasks() {
            if (!File.Exists(FilePath)) {
                return new List<Task>();
            }

            string json = File.ReadAllText(FilePath);
            return JsonSerializer.Deserialize<List<Task>>(json) ?? new List<Task>();
        }
        
        /* Converts the list in a string, then writes it on the json file, replacing the 
         * content. */
        public void SaveTasks() {
            string json = JsonSerializer.Serialize(tasks);
            File.WriteAllText(FilePath, json);
        }

        /* Creates a new instance of the Task class, with a description and a generated ID, then
         * adds it to the list and saves the alterations. */
        public void AddTask(string description) {
            if (tasks.Count > 0) {
                newId = tasks[^1].Id + 1;
            }
            else {
                newId = 1;
            }

            var newTask = new Task(description) {
                Id = newId
            };
            tasks.Add(newTask);
            SaveTasks();
            Console.WriteLine($"Task added succesfully (ID: {newId})");
        }

        public void ListTasks() {
            foreach (var task in tasks) {
                Console.WriteLine(task.Id + ". " + task.Description);
            }          
        }

        public void DeleteTask(int Id) {
            int index = Id - 1;
            string removed = tasks[index].Description;
            tasks.RemoveAt(index);
            foreach (var task in tasks) {
                if (task.Id > index) {
                    task.Id -= 1; 
                }
            }
            Console.WriteLine($"{removed} was deleted");
            SaveTasks();
        }

        public void UpdateTask(int Id, string desc) {
            int index = Id - 1;
            tasks[index].Description = desc;
            Console.WriteLine($"Task {Id} was updated");
            SaveTasks();
        }
    }
}

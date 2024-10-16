using System;

namespace TaskManagerCLI.Entities {
    internal class Task {
        public int Id { get; set; }
        public string Description { get; set; }
        public string Status { get; set; } // "todo", "in-progress", "done"
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public Task(string description) {
            Description = description;
            Status = "todo";
            CreatedAt = DateTime.Now;
            UpdatedAt = DateTime.Now;
        }
    }
}

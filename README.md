# Task Tracker
Solution for the [task-tracker](https://roadmap.sh/projects/task-tracker) project from [roadmap.sh](https://roadmap.sh).
This is a simple task manager application that uses the command line interface (CLI). All tasks are stored locally in a JSON file — no external libraries or databases required.

---

## 💻 Technologies Used

- [.NET 8](https://dotnet.microsoft.com/en-us/)
- C#
- Command Line Interface (CLI)

---

## ⚙️ Getting Started

First you will need to clone this repository and go to the directory where you cloned it:

```bash
git clone https://github.com/gmalisse/task-manager-cli.git

cd backend-projects/task-manager-cli
```

---

## 📌 Available Commands

All commands below should be executed from the project root:

### ➕ Adding a new task

```bash
dotnet run add "Buy groceries"
```

### ❌ Deleting tasks

```bash
dotnet run delete 1
```

### 📝 Updating tasks

```bash
dotnet run update 1 "Buy groceries and cook dinner"
```

### 🔄 Changing the task status

```
dotnet run mark in-progress 1

dotnet run mark done 1

dotnet run mark todo 1
```

### 📋 Listing tasks

```
dotnet run list

dotnet run list done

dotnet run list todo

dotnet run list in-progress
```

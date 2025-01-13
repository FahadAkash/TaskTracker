# Task Tracker

Task Tracker is a simple command line interface (CLI) application designed to help you track and manage your tasks. This project allows you to practice your programming skills, including working with the filesystem, handling user inputs, and building a simple CLI application.

## Features

- Add, update, and delete tasks
- Mark a task as in progress or done
- List all tasks
- List tasks based on their status (done, not done, in progress)

## Requirements

- .NET Core SDK

## Getting Started

To get started with Task Tracker, follow these steps:
 
```bash
 **Clone the repository:**
git clone https://github.com/yourusername/task-tracker.git
cd task-tracker

Build the project:
dotnet build
dotnet run [command] [arguments]
Commands
add <description>: Add a new task with the given description.

update <id> <description> <status>: Update the task with the given ID, description, and status.

delete <id>: Delete the task with the given ID.

list: List all tasks.

list-done: List all tasks that are done.

list-not-done: List all tasks that are not done.

list-in-progress: List all tasks that are in progress.
Examples
Add a new task:
dotnet run add "Write a blog post"
Update an existing task:
dotnet run update 1 "Write a detailed blog post" "In Progress"
Delete a task:
dotnet run delete 1
List all tasks:
dotnet run list
List tasks that are done:
dotnet run list-done
List tasks that are not done:
dotnet run list-not-done
List tasks that are in progress:
dotnet run list-in-progress
```


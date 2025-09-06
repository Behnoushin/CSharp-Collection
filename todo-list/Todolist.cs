using System;
using System.Collections.Generic;

class Task
{
    public string Title { get; set; }
    public bool IsDone { get; set; } = false;
}

class Program
{
    static List<Task> tasks = new List<Task>();

    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("🌸 Welcome to the To-Do List! 🌸");
        Console.ResetColor();

        while (true)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nPlease select an option:");
            Console.WriteLine("1. Add task");
            Console.WriteLine("2. View tasks");
            Console.WriteLine("3. Mark task as done");
            Console.WriteLine("4. Delete task");
            Console.WriteLine("5. Exit");
            Console.ResetColor();

            string choice = Console.ReadLine() ?? "";

            switch (choice)
            {
                case "1": AddTask(); break;
                case "2": ViewTasks(); break;
                case "3": MarkTaskDone(); break;
                case "4": DeleteTask(); break;
                case "5":
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("Thank you for using the To-Do List. Goodbye! 💖");
                    Console.ResetColor();
                    return;
                default:
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("❌ Invalid choice. Please try again ❌");
                    Console.ResetColor();
                    break;
            }
        }
    }

    static void AddTask()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Enter the task: ");
        Console.ResetColor();

        string title = Console.ReadLine() ?? "";
        tasks.Add(new Task { Title = title });

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("✨ Task added successfully! ✨");
        Console.ResetColor();
    }

    static void ViewTasks()
    {
        if (tasks.Count == 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("No tasks in the to-do list.");
            Console.ResetColor();
            return;
        }

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("📋 Tasks in the to-do list:");
        Console.ResetColor();

        for (int i = 0; i < tasks.Count; i++)
        {
            string status = tasks[i].IsDone ? "✅" : "❌";
            Console.ForegroundColor = tasks[i].IsDone ? ConsoleColor.Green : ConsoleColor.Gray;
            Console.WriteLine($"{i + 1}. {tasks[i].Title} {status}");
            Console.ResetColor();
        }
    }

    static void MarkTaskDone()
    {
        if (tasks.Count == 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("No tasks to mark as done.");
            Console.ResetColor();
            return;
        }

        ViewTasks();

        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Enter task number to mark as done: ");
        Console.ResetColor();

        if (int.TryParse(Console.ReadLine(), out int num) && num > 0 && num <= tasks.Count)
        {
            tasks[num - 1].IsDone = true;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("🌟 Task marked as done! 🌟");
            Console.ResetColor();
        }
        else
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("❌ Invalid number");
            Console.ResetColor();
        }
    }

    static void DeleteTask()
    {
        if (tasks.Count == 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("No tasks to delete.");
            Console.ResetColor();
            return;
        }

        ViewTasks();

        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Enter task number to delete: ");
        Console.ResetColor();

        if (int.TryParse(Console.ReadLine(), out int num) && num > 0 && num <= tasks.Count)
        {
            tasks.RemoveAt(num - 1);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Task deleted successfully!");
            Console.ResetColor();
        }
        else
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("❌ Invalid number");
            Console.ResetColor();
        }
    }
}

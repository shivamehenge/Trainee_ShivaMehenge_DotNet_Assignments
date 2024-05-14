using System;
using System.Collections.Generic;

class Program
{
    static List<string> tasks = new List<string>();

    static void Main(string[] args)
    {
        while (true)
        {

            //CRUD Operation- Select option as per requirement
            Console.WriteLine("Task List Application");
            Console.WriteLine("1. Create a task");
            Console.WriteLine("2. Read tasks");
            Console.WriteLine("3. Update a task");
            Console.WriteLine("4. Delete a task");
            Console.WriteLine("5. Exit");               //Click 5 for Exit
            Console.Write("Select an option: ");

            int option;
            if (!int.TryParse(Console.ReadLine(), out option))
            {
                Console.WriteLine("Invalid input. Please enter a number.");        //Invalit asnwer while choosing wrong Input 
                continue;
            }

            switch (option)
            {
                case 1:
                    CreateTask();               // CRUD Operation Where C -> Create
                    break;
                case 2:
                    ReadTasks();               // CRUD Operation Where R -> Read
                    break;
                case 3:
                    UpdateTask();             // CRUD Operation Where U -> Update
                    break;
                case 4:
                    DeleteTask();             // CRUD Operation Where C -> Delete
                    break;
                case 5:
                    return;
                default:
                    Console.WriteLine("Invalid option. Please select again.");       //Output while intering the invalid switch-case option
                    break;
            }
        }
    }
    // Actual CRUD Operation code
    //Create Task By putting input as 1
    static void CreateTask()
    {
        Console.Write("Enter task title: ");
        string title = Console.ReadLine();
        tasks.Add(title);
        Console.WriteLine("Task created successfully.");
    }
    //Read Task By Putting 2
    static void ReadTasks()
    {
        Console.WriteLine("Tasks:");
        if (tasks.Count == 0)
        {
            Console.WriteLine("No tasks available.");
        }
        else
        {
            for (int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {tasks[i]}");
            }
        }
    }
    //Update Task By putting 3
    static void UpdateTask()
    {
        if (tasks.Count == 0)
        {
            Console.WriteLine("No tasks available to update.");
            return;
        }

        Console.Write("Enter the index of the task to update: ");
        int index;
        if (!int.TryParse(Console.ReadLine(), out index) || index < 1 || index > tasks.Count)
        {
            Console.WriteLine("Invalid index.");
            return;
        }

        Console.Write("Enter new title: ");
        string newTitle = Console.ReadLine();
        tasks[index - 1] = newTitle;
        Console.WriteLine("Task updated successfully.");
    }
    //Delete the Task Putting 4
    static void DeleteTask()
    {
        if (tasks.Count == 0)
        {
            Console.WriteLine("No tasks available to delete.");
            return;
        }

        Console.Write("Enter the index of the task to delete: ");
        int index;
        if (!int.TryParse(Console.ReadLine(), out index) || index < 1 || index > tasks.Count)
        {
            Console.WriteLine("Invalid index.");
            return;
        }

        tasks.RemoveAt(index - 1);
        Console.WriteLine("Task deleted successfully.");
    }
}

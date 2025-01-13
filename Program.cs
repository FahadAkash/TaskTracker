using TaskTracker.Controller;
using TaskTracker.Data;
using TaskTracker.Service;

var repository = new TaskReposetory();
var taskService = new TaskService(repository);
var controller = new TaskController(taskService);


if(args.Length == 0)
{
    Console.WriteLine("Usage : dotnet run [add|update|delete|list|list-one|list-not-done|list-in-progrss");
    return;
}
switch (args[0].ToLower())
{
    case "add":
        if(args.Length > 1)
        {
            controller.AddTask(args[1]);
        }
        else
        {
            Console.WriteLine("Usage : dotnet run add <description>");

        }
        break;
    case "update":
        if(args.Length > 2)
        {
            int id;
            if(int.TryParse(args[2], out id))
            {
               controller.UpdateTask(id , args[2] , args[3]);
            }
            else
            {
                Console.WriteLine("Invalid task ID.");

            }
        }
        else
        {
            Console.WriteLine("Usage : dotnet run Update <id> <description> <status>");
        }
        break;
    case "delete":
        if (args.Length > 1)
        {
            int id;
            if (int.TryParse(args[1], out id))
            {
                controller.DeleteTask(id);
            }
            else
            {
                Console.WriteLine("Invalid task ID ");
            }
        }
        else
        {
            Console.WriteLine("usage : dotnet run delete <id>");
        }
        break;
    case "list":
        controller.ListTasks();
        break;
    case "list-done":
        controller.ListTasksByStatus("Done");
        break;
    case "list-not-done":
        controller.ListTasksByStatus("Not Done");
        break;
    case "list-in-progress":
        controller.ListTasksByStatus("In Progress");
        break;
    default:
        Console.WriteLine("Unknow Command");
        break;

        
}
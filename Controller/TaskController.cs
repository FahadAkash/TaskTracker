using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskTracker.Model;
using TaskTracker.Service;

namespace TaskTracker.Controller
{
    public class TaskController(ITaskServices taskServices)
    {
        private readonly ITaskServices _taskServices = taskServices;
         
        public void AddTask(string description)
        {
            var tasks = new TaskItem { Description = description, Status = "Not Done" };
            _taskServices.AddTask(tasks);
        }
        public void UpdateTask(int id, string description, string status)
        {
            var task = new TaskItem { Id = id, Description = description, Status = status };
            _taskServices.UpdateTask(task);
        }
        public void DeleteTask(int id)
        {
            _taskServices.DeleteTask(id);
        }

        public void ListTasks()
        {
            var tasks = _taskServices.GetAllTasks();
            foreach (var task in tasks)
            {
                Console.WriteLine($"{task.Id} : {task.Description} : {task.Status}");
            }
        }
        public void ListTasksByStatus(string status)
        {
            var tasks = _taskServices.GetTasksbyStatus(status);
            foreach (var item in tasks)
            {
                Console.WriteLine($"{item.Id} : {item.Description} : {item.Status}");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskTracker.Model;

namespace TaskTracker.Service
{
    public interface ITaskServices
    {
        void AddTask(TaskItem item);
        void UpdateTask(TaskItem item);
        void DeleteTask(int item);
        TaskItem GetTaskItem(int item);
        IEnumerable<TaskItem> GetAllTasks();    
        IEnumerable<TaskItem> GetTasksbyStatus(string status);

    }
}

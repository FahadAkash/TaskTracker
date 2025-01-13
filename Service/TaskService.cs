using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskTracker.Data;
using TaskTracker.Model;

namespace TaskTracker.Service
{
    internal class TaskService : ITaskServices
    {
        private readonly TaskReposetory _taskReposetory;
        public TaskService(TaskReposetory taskReposetory)
        {
            _taskReposetory = taskReposetory;   
        }
        public void AddTask(TaskItem item)
        {
            _taskReposetory.AddTask(item);
        }

        public void DeleteTask(TaskItem item)
        {
            _taskReposetory.DeleteTask(item);
        }

        public void DeleteTask(int item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TaskItem> GetAllTasks()
        {
          return  _taskReposetory.GetAllTasks();
        }

        public TaskItem GetTaskItem(int item)
        {
            return _taskReposetory.GetTaskItem(item);
        }

        public IEnumerable<TaskItem> GetTasksbyStatus(string status)
        {
             return _taskReposetory.GetTasksByStatus(status);
        }

        public void UpdateTask(TaskItem item)
        {
             _taskReposetory.UpdateTask(item);
        }
    }
}

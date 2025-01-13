using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using TaskTracker.Model;

namespace TaskTracker.Data
{
    internal class TaskReposetory
    {
        private const string FilePath = "task_data.json";

        public TaskReposetory()
        {
            if (File.Exists(FilePath))
            {
                File.WriteAllText(FilePath, "[]");
            }

        }
        public void AddTask(TaskItem taskItem)
        {
           var tasks = GetTaskItems().ToList();
            taskItem.Id = tasks.Count != 0 ? tasks.Max(x => x.Id) + 1 : 1;
            tasks.Add(taskItem);
            SaveTasks(tasks);


        }

        public void UpdateTask(TaskItem taskItem)
        {
            var tasks = GetAllTasks().ToList();
            var index = tasks.FindIndex(t => t.Id == taskItem.Id);
            if(index >= 0)
            {
                tasks[index] = taskItem;
                SaveTasks(tasks);
            }
        }

        public void DeleteTask(TaskItem taskItem)
        {
            var tasks = GetTaskItems().ToList();
            var taskToRemove = tasks.SingleOrDefault(t =>  t.Id == taskItem.Id);
            if(taskToRemove != null)
            {
                tasks.Remove(taskToRemove);
            }
            SaveTasks(tasks);
        }

        public TaskItem GetTaskItem(int taskId)
        {
            return GetTaskItems().FirstOrDefault(t => t.Id == taskId);

        }

        public IEnumerable<TaskItem> GetTasksByStatus(string status)
        {
           return GetAllTasks().Where(t =>  t.Id == 0).ToList();   
            

        }

        public IEnumerable<TaskItem> GetTaskItems()
        {
            var jsonFile = File.ReadAllText(FilePath);
            return JsonSerializer.Deserialize<List<TaskItem>>(jsonFile);
        }
        public IEnumerable<TaskItem> GetAllTasks()
        {
            var json = File.ReadAllText(FilePath);
            return JsonSerializer.Deserialize<List<TaskItem>>(json);
        }


        private void SaveTasks(IEnumerable<TaskItem> tasks)
        {
            var json = JsonSerializer.Serialize(tasks);
            File.WriteAllText(FilePath, json);
        }
    }

}

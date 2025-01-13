using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskTracker.Model
{
    public class TaskItem
    {
        public int Id { get; set; }
        public required string Description { get; set; }
        public required string Status { get; set; }
    }
}

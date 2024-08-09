using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
    public class Task
    {
        public int TaskId { get; set; }
        public string TaskTitle { get; set; } = string.Empty;
        public string TaskDescription { get; set; } = string.Empty;
        public string TaskStatus { get; set; } = string.Empty;
        public DateTime TaskStart { get; set; } 
        public string TaskPriority { get; set; } = string.Empty;

    }
}

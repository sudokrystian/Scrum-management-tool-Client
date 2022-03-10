using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebCoreMVC.NET.Models {
    public class Task {
        public long taskId { get; set; }
        public long sprintUserStoryId { get; set; }
        public string description { get; set; }
        public string status { get; set; }

        public Task()
        {

        }
        public Task(long TaskId, long SprintUserStoryId, string Description, string Status) {
            taskId = TaskId;
            sprintUserStoryId = SprintUserStoryId;
            description = Description;
            status = Status;
        }
    }
}
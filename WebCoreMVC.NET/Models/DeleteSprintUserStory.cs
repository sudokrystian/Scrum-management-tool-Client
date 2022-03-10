using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebCoreMVC.NET.Models {
    public class DeleteSprintUserStory {
        public int projectId { get; set; }
        public int sprintId { get; set; }
        public int userStoryId { get; set; }

        public DeleteSprintUserStory()
        {

        }

        public DeleteSprintUserStory(int projectId, int sprintId, int userStoryId)
        {
            this.projectId = projectId;
            this.sprintId = sprintId;
            this.userStoryId = userStoryId;
        }
    }
}

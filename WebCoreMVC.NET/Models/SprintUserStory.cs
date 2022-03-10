using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebCoreMVC.NET.Models {
    public class SprintUserStory {

        public int sprintUserStoryId { get; set; }
        public int userStoryId { get; set; }
        public string priority { get; set; }
        public string description { get; set; }
        public int difficulty { get; set; }
        public string status { get; set; }
        public int sprintBacklogId { get; set; }

        public SprintUserStory()
        {

        }

        public SprintUserStory(int sprintUserStoryId, int userStoryId, string priority, string description, int difficulty, string status, int sprintBacklogId)
        {
            this.sprintUserStoryId = sprintUserStoryId;
            this.userStoryId = userStoryId;
            this.priority = priority;
            this.description = description;
            this.difficulty = difficulty;
            this.status = status;
            this.sprintBacklogId = sprintBacklogId;
        }
    }
}

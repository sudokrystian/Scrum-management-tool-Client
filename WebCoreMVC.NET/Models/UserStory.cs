namespace WebCoreMVC.NET.Models {
    public class UserStory {
        public int userStoryId { get; set; }
        public int projectId { get; set; }
        public string priority { get; set; }
        public string description { get; set; }
        public int difficulty { get; set; }
        public string status { get; set; }

        public UserStory()
        {

        }
        public UserStory(int userStoryId, int projectId, string priority, string description, int difficulty, string status)
        {
            this.userStoryId = userStoryId;
            this.projectId = projectId;
            this.priority = priority;
            this.description = description;
            this.difficulty = difficulty;
            this.status = status;
        }
    }
}
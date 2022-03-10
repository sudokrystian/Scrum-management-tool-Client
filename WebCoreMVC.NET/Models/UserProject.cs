namespace WebCoreMVC.NET.Models {
    public class UserProject {
        public int projectId { get; set; }
        public string username { get; set; }

        public UserProject()
        {

        }
        public UserProject(int projectId, string username)
        {
            this.projectId = projectId;
            this.username = username;
        }
    }
}
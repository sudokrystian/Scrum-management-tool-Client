namespace WebCoreMVC.NET.Models
{
    public class UserWithName
    {
        public string username { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public bool scrumMaster { get; set; }
        public bool productOwner { get; set; }
    }
}
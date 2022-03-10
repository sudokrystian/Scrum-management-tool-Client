using System.Collections.Generic;

namespace WebCoreMVC.NET.Models
{
    public class UserWithNameAndRoles : UserWithName
    {
        public bool isScrumMaster { get; set; }
        public bool isProductOwner { get; set; }

        public UserWithNameAndRoles()
        {

        }

        public UserWithNameAndRoles(string username, string firstName, string lastName, bool isScrumMaster, bool isProductOwner)
        {
            base.username = username;
            base.firstName = firstName;
            base.lastName = lastName;
            this.isScrumMaster = isScrumMaster;
            this.isProductOwner = isProductOwner;
        }
    }
}
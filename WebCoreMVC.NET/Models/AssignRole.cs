using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebCoreMVC.NET.Models {
    public class AssignRole {
        public string username { get; set; }
        public int sprintId { get; set; }

        public AssignRole()
        {

        }

        public AssignRole(string username, int sprintId)
        {
            this.username = username;
            this.sprintId = sprintId;
        }
    }
}

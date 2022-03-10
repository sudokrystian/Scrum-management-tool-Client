using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebCoreMVC.NET.Models {
    public class ProjectIDandAdministrator {
        public int projectId { get; set; }
        public bool isAdministrator { get; set; }

        public ProjectIDandAdministrator()
        {

        }

        public ProjectIDandAdministrator(int projectId, bool isAdministrator)
        {
            this.projectId = projectId;
            this.isAdministrator = isAdministrator;
        }
    }
}

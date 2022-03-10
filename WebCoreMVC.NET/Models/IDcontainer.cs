using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebCoreMVC.NET.Models {
    public class IDcontainer {

        public int projectId { get; set; }
        public int sprintId { get; set; }

        public IDcontainer()
        {

        }
        public IDcontainer(int projectId, int sprintId)
        {
            this.projectId = projectId;
            this.sprintId = sprintId;
        }
    }
}

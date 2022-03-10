using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebCoreMVC.NET.Models {
    public class Sprint {
        public int projectId { get; set; }
        public int sprintId { get; set; }
        public int sprintNumber { get; set; }
        public string dateStarted { get; set; }
        public string dateFinished { get; set; }
        public string productOwnerUsername { get; set; }
        public string scrumMasterUsername { get; set; }
        public string status { get; set; }
        public bool isScrumMaster { get; set; }
        public bool isProductOwner { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebCoreMVC.NET.Models {
    public class SystemUser : LogginUser {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string birthday { get; set; }
        public string dateJoined { get; set; }
        public string profilePicture { get; set; }
    }
}
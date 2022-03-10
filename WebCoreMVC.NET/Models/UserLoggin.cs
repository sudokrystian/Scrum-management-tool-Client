using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebCoreMVC.NET.Models {
    public class LogginUser {
        [Required(ErrorMessage = "Please insert your username")]
        [StringLength(250, MinimumLength = 3, ErrorMessage = "Min 3 letters")]
        public string username { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Insert your password")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Min 3, max 50 letters")]
        public string password { get; set; }
    }
}
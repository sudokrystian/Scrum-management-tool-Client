using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebCoreMVC.NET.Models {
    public class ValidatedUser : SystemUser {
        [DataType(DataType.Password)]
        [Compare("password", ErrorMessage = "Password doesn't match!")]
        public string confirmPassword { get; set; }
    }
}
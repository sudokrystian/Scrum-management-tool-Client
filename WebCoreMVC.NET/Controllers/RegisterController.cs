using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebCoreMVC.NET.Models;

namespace WebCoreMVC.NET.Controllers {
    public class RegisterController : CustomController {
        public IActionResult Index() {
            return View("Index");
        }

        public IActionResult Register(ValidatedUser user) {
            if (ModelState.IsValid) {
                HttpResponseMessage response = SendRegisterData(user).Result;
                switch (response.StatusCode) {
                    case System.Net.HttpStatusCode.OK:
                        username = user.username;
                        return RedirectToAction("Index", "Home");
                    case System.Net.HttpStatusCode.BadRequest:
                        ModelState.AddModelError(string.Empty,
                            "Works but server gave bad request: " + response.Content);
                        return Index();
                    default:
                        ModelState.AddModelError(string.Empty, "Not connected to server at all");
                        return Index();
                }
            }
            else {
                ModelState.AddModelError(string.Empty, "Please insert the necessary data");
                return View("Index");
            }
        }

        private async Task<HttpResponseMessage> SendRegisterData(ValidatedUser user) {
            //Remember to hash password here before creating an instance of the user
            String password = user.password;
            String hashedValue = GetSha256(password);

            SystemUser systemUser = new SystemUser();
            systemUser.username = user.username;
            systemUser.password = hashedValue;
            systemUser.firstName = user.firstName;
            systemUser.lastName = user.lastName;
            systemUser.birthday = user.birthday;
            systemUser.dateJoined = user.dateJoined;
            systemUser.profilePicture = user.profilePicture;


            var response = await PostData(systemUser, "auth/register");
            //This if statement will be more specific after implementing server HTTP calls
            return response;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebCoreMVC.NET.Models;
using System.Diagnostics;

namespace WebCoreMVC.NET.Controllers {
    [Authorize(Policy = "MustBeUser")]
    public class MembersController : CustomController {
        public IActionResult Index(int projectId)
        {
            var list = GetUsersInProjects(projectId).Result;
            var result = JsonConvert.DeserializeObject<List<UserWithName>>(list);
            ContainerForListAndId<UserWithName> containerForListAndId = new ContainerForListAndId<UserWithName>(result, projectId);
            return View("~/Views/Project/Members/Index.cshtml",containerForListAndId);
        }

        public IActionResult AddMember(int projectId) {
            var list = GetUsersOutsideProject(projectId).Result;
            var result = JsonConvert.DeserializeObject<List<UserWithName>>(list);
            ContainerForListAndId<UserWithName> containerForListAndId = new ContainerForListAndId<UserWithName>(result, projectId);
            return View("~/Views/Project/Members/AddMember.cshtml", containerForListAndId);
        }

        public IActionResult DeleteMember(UserProject user)
        {
            var result = DeleteMemberRequest(user).Result;
            if (result.IsSuccessStatusCode)
            {
                return Index(user.projectId);
            }
            else
            {
                ModelState.AddModelError(string.Empty, "Delete member Server sent a bad request: " + result.Content);
                return Index(user.projectId);
            }
        }

        public IActionResult PostMember(UserProject user) {
            var response = SendMemberData(user).Result;
            switch(response.StatusCode) {
                case HttpStatusCode.OK:
                    return AddMember(user.projectId);
                case HttpStatusCode.BadRequest:
                    ModelState.AddModelError(string.Empty, "Post Member Server sent a bad request: " + response.Content);
                    return AddMember(user.projectId);
                default:
                    ModelState.AddModelError(string.Empty, "Server is not answering");
                    return AddMember(user.projectId);
            }            
        }

        public IActionResult AddAdministrator(UserProject user)
        {
            var response = AssignAdministratorRequest(user).Result;
            switch (response.StatusCode)
            {
                case HttpStatusCode.OK: 
                    return AddMember(user.projectId);
                case HttpStatusCode.BadRequest:
                    ModelState.AddModelError(string.Empty, "Add Administrator Server sent a bad request: " + response.Content);
                    return AddMember(user.projectId);
                default:
                    ModelState.AddModelError(string.Empty, "Server is not answering");
                    return AddMember(user.projectId);
            }
        }

        public IActionResult RemoveAdministrator(UserProject user)
        {
            var response = RemoveAdministratorRequest(user).Result;
            switch (response.StatusCode)
            {
                case HttpStatusCode.OK:
                    return AddMember(user.projectId);
                case HttpStatusCode.BadRequest:
                    ModelState.AddModelError(string.Empty, "Server sent a bad request: " + response.Content);
                    return AddMember(user.projectId);
                default:
                    ModelState.AddModelError(string.Empty, "Server is not answering");
                    return AddMember(user.projectId);
            }
        }

        public string GetUsersOutiseProjectJsonString(int projectId)
        {
            var content = GetUsersOutsideProject(projectId).Result;
            return content;
        }

        [HttpPost]
        public string SendMemberDataJS(UserProject user)
        {
            var content = SendMemberData(user).Result;
            if (content.IsSuccessStatusCode)
            {
                return "{\"status\":\"ok\"}";
            }
            return "{\"status\":\"error\"}";
        }

        public string DeleteMemberRequestJS(UserProject user)
        {
            var response = DeleteMemberRequest(user).Result;
            if (response.IsSuccessStatusCode)
            {
                return "{\"status\":\"ok\"}";
            }
            return "{\"status\":\"error\"}";
        }

        [HttpPost]
        private async Task<HttpResponseMessage> SendMemberData(UserProject user) {
            Debug.WriteLine(user.ToString());
            var httpContent = await PostData(user, "api/addUser");
            return httpContent;
        }
        
        private async Task<HttpResponseMessage> DeleteMemberRequest(UserProject user) {
            var httpContent = await PostData(user, "api/removeUser");
            return httpContent;
        }

        private async Task<HttpResponseMessage> AssignAdministratorRequest(UserProject user)
        {
            var httpContent = await PostData(user, "api/assignAdmin");
            return httpContent;
        }

        private async Task<HttpResponseMessage> RemoveAdministratorRequest(UserProject user)
        {
            var httpContent = await PostData(user, "api/removeAdmin");
            return httpContent;
        }
        
        private async Task<string> GetUsersInProjects(int projectId) {
            Console.WriteLine("api/usersInProjects?projectId=" + projectId);
            var content = await GetJsonData("api/usersInProject?projectId=" + projectId);
            return content;
        }
        private async Task<string> GetUsersOutsideProject(int projectId) {
            var content = await GetJsonData("api/usersOutsideProject?projectId=" + projectId);
            return content;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebCoreMVC.NET.Models;

namespace WebCoreMVC.NET.Controllers {
    [Authorize(Policy = "MustBeUser")]
    public class BacklogController : CustomController
    {
        private int sprintId;
        private int projectId;
        public IActionResult Index(int projectId)
        {
            this.projectId = projectId;
            var list = GetUserStoriesForProject(projectId).Result;
            var result = JsonConvert.DeserializeObject<List<UserStory>>(list);
            ContainerForListAndId<UserStory> containerForListAndId = new ContainerForListAndId<UserStory>(result, projectId);
            return View("~/Views/Project/Backlog/Index.cshtml", containerForListAndId);
        }
        
        public IActionResult PostUserStory()
        {
            string priority = Request.Form["priority"];
            string description = Request.Form["description"];
            int difficulty = int.Parse(Request.Form["difficulty"]);
            int sprintId = int.Parse(Request.Form["sprintId"]);
            //TODO
            int productBacklogId = 1;
            //-----------------------
            UserStory userStory = new UserStory(-1, productBacklogId, priority, description, difficulty, "ONGOING");
            var response = AddUserStoryRequest(userStory).Result;
            if(response.IsSuccessStatusCode)
            {
                return Index(sprintId);
            }
            ModelState.AddModelError(string.Empty, "Server sent a bad request: " + response.Content);
            return Index(sprintId);
        }
        
        public IActionResult DeleteUserStory(UserStory userStory)
        {
            var response = DeleteUserStoryRequest(userStory.userStoryId).Result;
            if (response.IsSuccessStatusCode)
            {
                return Index(userStory.projectId);
            }

            return Index(userStory.projectId);
        }

        public IActionResult BacklogFromLastSprint(int projectId)
        {
            // that doesn't worj first we have to figure out which sprint is the newest and get user stories for that spring'
            return Index(projectId);
        }

        public string AddUserStoryToProjectJS(UserStory userStory)
        {
            var content = AddUserStoryRequest(userStory).Result;
            if (content.IsSuccessStatusCode)
            {
                return "{\"status\":\"ok\"}";
            }
            return "{\"status\":\"error\"}";
        }

        public string GetUserStoriesForProjectJS(int projectId)
        {
            var content = GetUserStoriesForProject(projectId).Result;
            return content;
        }

        private async Task<string> GetUserStoriesForProject(int projectId) {
            var content = await GetJsonData("api/userStory?projectId="+projectId);
            return content;
        }

        private async Task<string> GetUserStoriesForSprint(int sprintId)
        {
            var httpContent = await GetJsonData("api/sprintUserStory?sprintId=" + sprintId);
            return httpContent;
        }

        private async Task<HttpResponseMessage> AddUserStoryRequest(UserStory userStory) {
            var httpContent = await PostData(userStory, "api/userStory");
            return httpContent;
        }
        
        private async Task<HttpResponseMessage> DeleteUserStoryRequest(int userStoryId) {
            var httpContent = await DeleteData("api/userStory?userStoryId=" + userStoryId);
            return httpContent;
        }
    }
}

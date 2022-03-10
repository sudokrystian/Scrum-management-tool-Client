using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebCoreMVC.NET.Models;
using Task = WebCoreMVC.NET.Models.Task;

namespace WebCoreMVC.NET.Controllers {
    [Authorize(Policy = "MustBeUser")]
    public class TasksController : CustomController {
        public IActionResult Index(int sprintId) {
            var list = GetTasksForSprint(sprintId).Result;
            var result = JsonConvert.DeserializeObject<List<Task>>(list);
            return View("~/Views/Project/Sprint/Tasks/Index.cshtml", result);
        }
        public string GetTasksForUserStoryJS(int sprintUserStoryId)
        {
            var content = GetTasksForUserStory(sprintUserStoryId).Result;
            return content;
        }

        public string AddTaskToTheUserStoryJS(Task task)
        {
            var content = AddTaskToTheUserStory(task).Result;
            if (content.IsSuccessStatusCode)
            {
                return "{\"status\":\"ok\"}";
            }
            return "{\"status\":\"error\"}";
        }
        private async Task<string> GetTasksForUserStory(int sprintUserStoryId) {
            var content = await GetJsonData("api/task?sprintUserStoryId=" + sprintUserStoryId);
            return content;
        }    

        private async Task<HttpResponseMessage> AddTaskToTheUserStory(Task task)
        {
            var content = await PostData(task, "api/task");
            return content;
        }

        private async Task<string> GetTasksForSprint(int sprintId)
        {
            var content = await GetJsonData("api/task?sprintId=" + sprintId);
            return content;
        }
    }
}
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebCoreMVC.NET.Models;

namespace WebCoreMVC.NET.Controllers {

    public class CustomController : Controller {

        //All controllers are reusing the same http client and server ip so there is no need to create them multiple times
        protected readonly HttpClient client = new HttpClient();
        protected readonly string serverUrl = "http://" + "localhost" + ":8081/";
        protected static string username { get; set; }
        protected List<Project> projects = new List<Project>();
        protected ContainerForListAndId<Sprint> sprints = new ContainerForListAndId<Sprint>();

        //Generic Post and Get methods
        public async Task<HttpResponseMessage> PostData(object data, string PostWhere) {
            var json = JsonConvert.SerializeObject(data);
            Debug.WriteLine(json);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PostAsync(serverUrl + PostWhere, content);
            return response;
        }

        public async Task<string> GetJsonData(string GetFromWhere) {
            var getStringTask = await client.GetStringAsync(serverUrl + GetFromWhere);
            return getStringTask;
        }

        public async Task<HttpResponseMessage> DeleteData(string parameter)
        {
            var httpRequest = await client.DeleteAsync(serverUrl + parameter);
            return httpRequest;
        }

        //Cryptography methods
        public static string GetSha256(string text) {
            if (text == null) return string.Empty;

            var message = Encoding.ASCII.GetBytes(text);
            var hashValue = GetSha256(message);

            var hashString = string.Empty;
            foreach (var x in hashValue) hashString += string.Format("{0:x2}", x);
            return hashString;
        }

        private static byte[] GetSha256(byte[] message) {
            var hashString = new SHA256Managed();
            return hashString.ComputeHash(message);
        }
    }
}
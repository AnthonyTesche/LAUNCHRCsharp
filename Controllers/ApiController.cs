using System;
using Services;
using Entities;
using Newtonsoft.Json;

namespace Controllers
{
    public class ApiController
    {
        public News ApiCallNews()
        {
            string url = "API URL";
            string key = "API KEY";
            Api api = new Api(url, key);
            News Notice = JsonConvert.DeserializeObject<News>(api.makeRequest().ToString());
            return Notice;
        }

        public string ApiCallExoPlanet()
        {
            string url = "API URL";
            string key = "API KEY";
            Api api = new Api(url, key);
            return api.makeRequest().ToString();
        }
    }
}

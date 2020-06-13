using System;
using System.Collections.Generic;
using System.Linq;
using Services;
using Entities;
using Newtonsoft.Json;

namespace Controllers
{
    public class ApiController
    {
        public News ApiCallNews()
        {
            string url = "https://api.nasa.gov/planetary/apod";
            string key = "?api_key=qExb1GxixvyuxsUefkckJ97Iykc6g8Q3WNirJFDQ";
            Api api = new Api(url, key);
            News Notice = new News();
            try
            {
                Notice = JsonConvert.DeserializeObject<News>(api.makeRequest().ToString());
                return Notice;
            } catch (Exception e)
            {
                //Chamar erros aqui "e"
            }
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

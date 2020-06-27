using System;
using System.Collections.Generic;
using System.Linq;
using Services;
using Entities;
using Newtonsoft.Json;
using System.Security.AccessControl;

namespace Controllers
{
    public class ApiController
    {
        public List<News> ApiCallNews(string searchInit = "", string searchFinish = "")
        {
            string url = "https://api.nasa.gov/planetary/apod";
            string key = "?api_key=qExb1GxixvyuxsUefkckJ97Iykc6g8Q3WNirJFDQ";
            string search = "&start_date=" + searchInit + "&end_date=" + searchFinish;
            List<News> Notice = new List<News>();
            try
            {
                if (String.IsNullOrEmpty(searchInit) && String.IsNullOrEmpty(searchFinish))
                {
                    string today = DateTime.Now.ToString("yyyy-MM-dd");
                    search = "&start_date=" + today + "&end_date=" + today;
                    Api api = new Api(url, key);
                    var news = JsonConvert.DeserializeObject<News>(api.makeRequest().ToString());
                    Notice.Add(news);
                    return Notice;
                } else
                {
                    key += search;
                    Api api = new Api(url, key);
                    var news = JsonConvert.DeserializeObject<IList<News>>(api.makeRequest().ToString());
                    foreach (News x in news)
                    {
                        Notice.Add(x);
                    }
                    return Notice;
                }
            } 
            catch (Exception e)
            {
                //Chamar erros aqui "e"
            }
            return Notice;
        }

        public List<ExoPlanet> ApiCallExoPlanet(string search = "false")
        {
            string url = "https://exoplanetarchive.ipac.caltech.edu/cgi-bin/nstedAPI/nph-nstedAPI?table=exoplanets&format=json";
            List<ExoPlanet> planet = new List<ExoPlanet>();
            if (search == "false")
            {
                string key = "";
                Api api = new Api(url, key);
                var entitiesPlanet = JsonConvert.DeserializeObject<IList<ExoPlanet>>(api.makeRequest().ToString());
                foreach(ExoPlanet x in entitiesPlanet)
                {
                    planet.Add(x);
                }
                
                return planet;
            } else
            {
                string key = "&where=pl_hostname%20like%20%27" + search + "%25%27&order=pl_hostname";
                Api api = new Api(url, key);
                var entitiesPlanet = JsonConvert.DeserializeObject<IList<ExoPlanet>>(api.makeRequest().ToString());
                foreach(ExoPlanet x in entitiesPlanet)
                {
                    planet.Add(x);
                }

                return planet;
            }
        }


    }
}

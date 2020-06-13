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
            string key = "API KEY";
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

        public List<ExoPlanet> ApiCallExoPlanet(string search)
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

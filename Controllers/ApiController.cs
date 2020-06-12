using System;
using Services;

namespace Controllers
{
    public class ApiController
    {
        public string ApiCall()
        {
            Api api = new Api();
            return api.makeRequest().ToString();
        }
    }
}

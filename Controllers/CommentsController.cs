using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Controllers
{
    class CommentsController
    {
        public static void addComment(string idPlanet, string text)
        {
            Comments com = new Comments();
            com.idPlanet = idPlanet;
            com.comment = text;


        }
    }
}

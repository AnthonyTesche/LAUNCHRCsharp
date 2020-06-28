using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Entities;
using Services;

namespace Controllers
{
    public class CommentsController
    {
        public void addComment(Comments com)
        {
            CommentService comServ = new CommentService();
            com.date = DateTime.Now.ToString("yyyy-MM-dd");
            comServ.InsertComment(com);
        }

        public List<Comments> getComments(string idPlanet)
        {
            CommentService comServ = new CommentService();
            comServ.selectComments(idPlanet);
            return comServ.selectComments(idPlanet);
        }
    }
}

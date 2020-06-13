using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class News
    {
        public string copyright { get; set; }
        public DateTime date { get; set; }
        public string explanation { get; set; }
        public string media { get; set; }
        public string media_type { get; set; }
        public string serv_versioin { get; set; }
        public string title { get; set; }
        public string url { get; set; }
    }
}

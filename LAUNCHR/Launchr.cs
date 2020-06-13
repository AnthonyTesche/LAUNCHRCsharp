using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;
using Controllers;
using System.Reflection;

namespace LAUNCHR
{
    public partial class Launchr : Form
    {
        public Launchr()
        {
            InitializeComponent();
            ApiController apiControl = new ApiController();
            //News
            News Notice = new News();
            Notice = apiControl.ApiCallNews();
            CopyrightText.Text = Notice.copyright;
            DateText.Text = Convert.ToString(Notice.date);
            ExplanationText.Text = Notice.explanation;
            MediaText.Text = Notice.hdurl;
            Media_typeText.Text = Notice.media_type;
            Service_VersionText.Text = Notice.service_version;
            TitleText.Text = Notice.title;
            UrlText.Text = Notice.url;

            //ExoPlanetas
            ExoPlanet planet = new ExoPlanet();
            //ApiCallExoPlanet tem siistema de pesquisa, "false"(string) para retornar lista de planetas, valor/nome do planeta retorna ele ou nomes parecidos
            foreach(ExoPlanet x in apiControl.ApiCallExoPlanet("false"))
            {
                Planets.Items.Add(x.pl_hostname);
            }
            pl_hostname.Text = planet.pl_hostname;
            //Utilizar variaveis do exoPlanets.js q enviei no DISCORD (Chat Desenvolvimento de Sistemas)
            //Adicionar explicações de cada uma das variaveis base no minimo | var base->(exoPlanets.js)
        }
    }
}

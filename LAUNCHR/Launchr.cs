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

            //Comments
            //Busca e adiciona comentarios atraves do pl_hostname de cada planeta


            //News
            List<News> Notice = new List<News>();
            Notice = apiControl.ApiCallNews();
            //ApiCallNews() possui sistema de pesquisa atraves ded datas sendo 1º param data inicial e 2º param ddata final da pesquisa
            //Retornando noticias entre os dias pesquisados
            foreach (News x in Notice)
            {
                CopyrightText.Text = x.copyright;
                DateText.Text = Convert.ToString(x.date);
                ExplanationText.Text = x.explanation;
                MediaText.Text = x.hdurl;
                Media_typeText.Text = x.media_type;
                Service_VersionText.Text = x.service_version;
                TitleText.Text = x.title;
                UrlText.Text = x.url;
            }

            //ExoPlanetas
            ExoPlanet planet = new ExoPlanet();
            //ApiCallExoPlanet() possui sistema de pesquisa, simplesmente chamar retornar lista de planetas, pl_hostname/nome do planeta retorna ele ou nomes parecidos
            foreach(ExoPlanet x in apiControl.ApiCallExoPlanet())
            {
                Planets.Items.Add(x.pl_hostname);
            }
            pl_hostname.Text = planet.pl_hostname;
            //Utilizar variaveis do exoPlanets.js q enviei no DISCORD (Chat Desenvolvimento de Sistemas)
            //Adicionar explicações de cada uma das variaveis base no minimo | var base->(exoPlanets.js)
        }
    }
}

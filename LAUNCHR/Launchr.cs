﻿using System;
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
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Channels;
using ShockwaveFlashObjects;

namespace LAUNCHR
{
    public partial class Launchr : Form
    {
        private bool mouseDown;
        private Point lastLocation;
        public delegate void x(News x);
        public Launchr()
        {
            InitializeComponent();
            DisableAll();
            //Comments
            //Busca e adiciona comentarios atraves do pl_hostname de cada planeta
            //CommentsController comController = new CommentsController();
            //comController.addComment("", "");


        }
        private void DisableAll(string caller = "")
        {
            ExoPageTitle.Visible = false;
            ExoPageDesc.Visible = false;
            ExoPlanetsChoose.Visible = false;
            NewsListTitle.Visible = false;
            NewsListText.Visible = false;
            FlowNewsPanel.Visible = false;
            CreditsPanel.Visible = false;
            SearchInit.Visible = false;
            SearchEnd.Visible = false;
            SearchInitLabel.Visible = false;
            SearchEndLabel.Visible = false;
            SearchButton.Visible = false;
            if(caller == "News")
            {
                SearchInit.Visible = true;
                SearchEnd.Visible = true;
                SearchInitLabel.Visible = true;
                SearchEndLabel.Visible = true;
                SearchButton.Visible = true;
                NewsListTitle.Visible = true;
                NewsListText.Visible = true;
                FlowNewsList.Visible = true;
            } else if(caller == "ExoPlanets"){
                FlowNewsList.Visible = false;
                ExoPlanetsChoose.Visible = true;
                ExoPageDesc.Visible = true;
                ExoPageTitle.Visible = true;
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void DragWindow_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void DragWindow_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void DragWindow_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void NewsPanel_Click(object sender, EventArgs e)
        {
            DisableAll("News");
            
            ApiController apiControl = new ApiController();
            List<News> Notice = new List<News>();
            Notice = apiControl.ApiCallNews();
            populateNewsList(Notice, sender, e);
        }
        private void NoticeShow_Click(object sender, EventArgs e, News x)
        {
            FlowNewsPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            FlowNewsPanel.WrapContents = false;
            FlowNewsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            FlowNewsPanel.AutoScroll = true;
            FlowNewsPanel.Visible = true;
            TitleNotice.Text = x.title;
            Date.Text = x.date.ToString("yyyy-MM-dd");
            DescriptionText.Text = x.explanation;
            if (x.media_type == "image")
            {
                Image.ImageLocation = x.hdurl;
            }
            else
            {
                LinkLabel videoUrl = new LinkLabel();
                Image.Image = LAUNCHR.Properties.Resources.nasa;
                Image.Size = new System.Drawing.Size(392, 218);
                videoUrl.Text = "Video available by NASA";
                videoUrl.Location = new System.Drawing.Point(423, 314);
                videoUrl.Click += new EventHandler((senderNoticeShow, eNoticeShow) => videoRedirect_Click(sender, e, x.url));
                NoticePanel.Controls.Add(videoUrl);
            }
            if(String.IsNullOrEmpty(x.copyright))
            {
                x.copyright = "NASA/Unknown";
            }
            Copyright.Text = "Text by " + x.copyright;
            Graphics g = CreateGraphics();
            DescriptionText.Height = (int)g.MeasureString(DescriptionText.Text,
            DescriptionText.Font, DescriptionText.Width).Height + 10;
            NoticePanel.AutoSize = true;
        }

        private void videoRedirect_Click(object sender, EventArgs e, string url)
        {
            System.Diagnostics.Process.Start(url+ "&autoplay=1");
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            FlowNewsPanel.Visible = false;
        }

        private void CreditPanel_Click(object sender, EventArgs e)
        {
            CreditsPanel.Visible = true;
        }

        private void populateNewsList(List<News> Notice,object sender, EventArgs e)
        {
            int xLabel = 16;
            int yLabel = 174;
            int xPicture = 15;
            int yPicture = 83;
            int count = 0;
            foreach (News x in Notice)
            {
                if (String.IsNullOrEmpty(x.explanation))
                {
                    MessageBox.Show("API não retornou noticias!");
                    return;
                }
                Label lbl = new Label();
                Label lblChoice = new Label();
                
                lblChoice.Location = new System.Drawing.Point(xPicture, yPicture);
                lblChoice.Text = x.date.ToString();
                lblChoice.Name = "LabelDate" + count.ToString();

                PictureBox pic = new PictureBox();
                pic.Location = new System.Drawing.Point(xPicture, yPicture);
                xPicture += 156;
                pic.Name = "Image" + count.ToString();
                if (x.media_type == "image")
                {
                    pic.ImageLocation = x.hdurl;
                } else
                {
                    pic.Image = LAUNCHR.Properties.Resources.nasa;
                }
                pic.SizeMode = PictureBoxSizeMode.StretchImage;
                pic.Size = new System.Drawing.Size(134, 92);
                pic.Click += new EventHandler((senderNoticeShow, eNoticeShow) => NoticeShow_Click(sender, e, x));
                NewsListPanel.Controls.Add(pic);

                lbl.Location = new System.Drawing.Point(xLabel, yLabel);
                xLabel += 156;
                lbl.Text = x.title;
                lbl.Name = "NewsLabel" + count.ToString();
                lbl.Size = new System.Drawing.Size(137, 31);
                NewsListPanel.Controls.Add(lbl);
                if (count == 3)
                {
                    xLabel = 12;
                    yLabel = 323;
                    xPicture = 15;
                    yPicture = 232;
                }
                else if (count == 7)
                {
                    return;
                }
                count++;
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            ApiController apiControl = new ApiController();
            List<News> Notice = new List<News>();
            if(!validate(SearchInit.Text, SearchEnd.Text))
            {
                MessageBox.Show("Complete all required fields");
                return;
            }
            Notice = apiControl.ApiCallNews(SearchInit.Text, SearchEnd.Text);
            populateNewsList(Notice, sender, e);
        }

        private bool validate(string init, string end)
        {
            bool pass = true;
            DateTime temp;
            if (String.IsNullOrEmpty(init) || init == "    -  -" || !DateTime.TryParse(init, out temp))
            {
                return false;
            } else if (String.IsNullOrEmpty(end) || end == "    -  -" || !DateTime.TryParse(end, out temp))
            {
                return false;
            }
            return pass;
        }
        private void ExoPlanetsPanel_Click(object sender, EventArgs e)
        {
            //Disable all
            DisableAll("ExoPlanets");
            
            //Enable all ExoPlanets Data
            ApiController apiControl = new ApiController();
            ExoPlanet planet = new ExoPlanet();
            foreach (ExoPlanet x in apiControl.ApiCallExoPlanet())
            {
                selectPlanetCombo.Items.Add(x.pl_hostname);
            }
        }

        private void selectPlanetButton_Click(object sender, EventArgs e)
        {
            ApiController apiControl = new ApiController();
            ExoPlanet planet = new ExoPlanet();
            foreach (ExoPlanet x in apiControl.ApiCallExoPlanet(selectPlanetCombo.SelectedItem.ToString()))
            {
                FormPlanet forPlanet = new FormPlanet(x, sender, e);
                forPlanet.ShowDialog();
                selectPlanetCombo.Refresh();
            }
        }

        private void searchPlanetButton_Click(object sender, EventArgs e)
        {
            ApiController apiControl = new ApiController();
            ExoPlanet planet = new ExoPlanet();
            int count = 0;
            foreach (ExoPlanet x in apiControl.ApiCallExoPlanet(searchPlanetBox.Text))
            {
                count++;
                FormPlanet forPlanet = new FormPlanet(x, sender, e);
                forPlanet.ShowDialog();
                if(count == 5)
                {
                    return;
                }
            }
        }
    }
}
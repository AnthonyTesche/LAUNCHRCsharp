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
        }
    }
}

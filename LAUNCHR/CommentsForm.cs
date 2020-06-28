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
using System.Security.Policy;

namespace LAUNCHR
{
    public partial class CommentsForm : Form
    {
        private bool mouseDown;
        private Point lastLocation;
        
        //Inicialização
        public CommentsForm(string ident)
        {
            InitializeComponent();
            titleComments.Text = ident;
            showComments();
        }

        // Comments Commands
        private void showComments()
        {
            flowComments.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            flowComments.WrapContents = false;
            flowComments.AutoScroll = true;
            CommentsController comController = new CommentsController();
            int xPanelL = 3;
            int yPanelL = 19;
            int xPanelS = 500;
            int yPanelS = 80;
            int count = 0;
            foreach (Comments x in comController.getComments(titleComments.Text))
            {
                Panel p = new Panel();
                p.Location = new System.Drawing.Point(xPanelL, yPanelL);
                p.Size = new System.Drawing.Size(xPanelS, yPanelS);
                p.Name = x.name + "CommentPanel";
                flowComments.Controls.Add(p);
                yPanelL += 106;

                Label lbl = new Label();
                lbl.Location = new System.Drawing.Point(0, 0);
                lbl.Text = x.name;
                lbl.Name = x.name + "NameLabel";
                p.Controls.Add(lbl);

                Label lblDate = new Label();
                lblDate.Location = new System.Drawing.Point(440, 0);
                lblDate.Text = x.date;
                lblDate.Name = "DateLabel" + count++;
                p.Controls.Add(lblDate);

                RichTextBox commentBox = new RichTextBox();
                commentBox.Location = new System.Drawing.Point(4, 21);
                commentBox.Size = new System.Drawing.Size(493, 56);
                commentBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
                commentBox.Text = x.comment;
                p.Controls.Add(commentBox);
            }
        }

        private void addCommentButon_Click(object sender, EventArgs e)
        {
            CommentsController comController = new CommentsController();
            Comments com = new Comments();
            com.name = addNameBox.Text;
            if (String.IsNullOrEmpty(com.name))
            {
                com.name = "Unknown";
            }
            com.comment = addComment.Text;
            com.idPlanet = titleComments.Text;
            if (validate(com))
            {
                MessageBox.Show("Type a comment");
            }
            comController.addComment(com);
            showComments();
        }

        private bool validate(Comments com)
        {
            bool error = false;
            
            if (String.IsNullOrEmpty(com.comment))
            {
                error = true;
            }
            return error;
        }


        //Form Commands / Fechar / Arrastar / Minimizar
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
    }
}

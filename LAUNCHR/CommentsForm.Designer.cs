namespace LAUNCHR
{
    partial class CommentsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CommentsForm));
            this.DragWindow = new System.Windows.Forms.Panel();
            this.LaunchrTitle = new System.Windows.Forms.Panel();
            this.Minimize = new System.Windows.Forms.Panel();
            this.ResSize = new System.Windows.Forms.Panel();
            this.Close = new System.Windows.Forms.Panel();
            this.titleComments = new System.Windows.Forms.Label();
            this.addNameLabel = new System.Windows.Forms.Label();
            this.addNameBox = new System.Windows.Forms.TextBox();
            this.addComment = new System.Windows.Forms.RichTextBox();
            this.addCommentButon = new System.Windows.Forms.Button();
            this.flowComments = new System.Windows.Forms.FlowLayoutPanel();
            this.DragWindow.SuspendLayout();
            this.SuspendLayout();
            // 
            // DragWindow
            // 
            this.DragWindow.BackColor = System.Drawing.SystemColors.MenuText;
            this.DragWindow.Controls.Add(this.LaunchrTitle);
            this.DragWindow.Location = new System.Drawing.Point(0, 0);
            this.DragWindow.Name = "DragWindow";
            this.DragWindow.Size = new System.Drawing.Size(800, 32);
            this.DragWindow.TabIndex = 8;
            this.DragWindow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragWindow_MouseDown);
            this.DragWindow.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DragWindow_MouseMove);
            this.DragWindow.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DragWindow_MouseUp);
            // 
            // LaunchrTitle
            // 
            this.LaunchrTitle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LaunchrTitle.BackgroundImage")));
            this.LaunchrTitle.Location = new System.Drawing.Point(8, 0);
            this.LaunchrTitle.Name = "LaunchrTitle";
            this.LaunchrTitle.Size = new System.Drawing.Size(122, 32);
            this.LaunchrTitle.TabIndex = 0;
            // 
            // Minimize
            // 
            this.Minimize.BackColor = System.Drawing.SystemColors.MenuText;
            this.Minimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Minimize.BackgroundImage")));
            this.Minimize.Location = new System.Drawing.Point(694, 0);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(32, 32);
            this.Minimize.TabIndex = 7;
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // ResSize
            // 
            this.ResSize.BackColor = System.Drawing.SystemColors.MenuText;
            this.ResSize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ResSize.BackgroundImage")));
            this.ResSize.Location = new System.Drawing.Point(732, 0);
            this.ResSize.Name = "ResSize";
            this.ResSize.Size = new System.Drawing.Size(32, 32);
            this.ResSize.TabIndex = 6;
            // 
            // Close
            // 
            this.Close.AutoSize = true;
            this.Close.BackColor = System.Drawing.SystemColors.MenuText;
            this.Close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Close.BackgroundImage")));
            this.Close.Location = new System.Drawing.Point(770, 0);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(32, 32);
            this.Close.TabIndex = 5;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // titleComments
            // 
            this.titleComments.AutoSize = true;
            this.titleComments.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleComments.Location = new System.Drawing.Point(285, 65);
            this.titleComments.Name = "titleComments";
            this.titleComments.Size = new System.Drawing.Size(146, 23);
            this.titleComments.TabIndex = 9;
            this.titleComments.Text = "Noticia/Planeta";
            // 
            // addNameLabel
            // 
            this.addNameLabel.AutoSize = true;
            this.addNameLabel.Location = new System.Drawing.Point(168, 114);
            this.addNameLabel.Name = "addNameLabel";
            this.addNameLabel.Size = new System.Drawing.Size(38, 13);
            this.addNameLabel.TabIndex = 17;
            this.addNameLabel.Text = "Name:";
            // 
            // addNameBox
            // 
            this.addNameBox.Location = new System.Drawing.Point(212, 111);
            this.addNameBox.Name = "addNameBox";
            this.addNameBox.Size = new System.Drawing.Size(100, 20);
            this.addNameBox.TabIndex = 18;
            // 
            // addComment
            // 
            this.addComment.Location = new System.Drawing.Point(170, 136);
            this.addComment.Name = "addComment";
            this.addComment.Size = new System.Drawing.Size(504, 77);
            this.addComment.TabIndex = 19;
            this.addComment.Text = "";
            // 
            // addCommentButon
            // 
            this.addCommentButon.Location = new System.Drawing.Point(599, 111);
            this.addCommentButon.Name = "addCommentButon";
            this.addCommentButon.Size = new System.Drawing.Size(75, 20);
            this.addCommentButon.TabIndex = 22;
            this.addCommentButon.Text = "Comment";
            this.addCommentButon.UseVisualStyleBackColor = true;
            this.addCommentButon.Click += new System.EventHandler(this.addCommentButon_Click);
            // 
            // flowComments
            // 
            this.flowComments.Location = new System.Drawing.Point(171, 237);
            this.flowComments.Name = "flowComments";
            this.flowComments.Size = new System.Drawing.Size(559, 201);
            this.flowComments.TabIndex = 23;
            // 
            // CommentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowComments);
            this.Controls.Add(this.addCommentButon);
            this.Controls.Add(this.addComment);
            this.Controls.Add(this.addNameBox);
            this.Controls.Add(this.addNameLabel);
            this.Controls.Add(this.titleComments);
            this.Controls.Add(this.Minimize);
            this.Controls.Add(this.ResSize);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.DragWindow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CommentsForm";
            this.Text = "CommentsForm";
            this.DragWindow.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel LaunchrTitle;
        private System.Windows.Forms.Panel Minimize;
        private System.Windows.Forms.Panel ResSize;
        private System.Windows.Forms.Panel Close;
        private System.Windows.Forms.Panel DragWindow;
        private System.Windows.Forms.Label titleComments;
        private System.Windows.Forms.Label addNameLabel;
        private System.Windows.Forms.TextBox addNameBox;
        private System.Windows.Forms.RichTextBox addComment;
        private System.Windows.Forms.Button addCommentButon;
        private System.Windows.Forms.FlowLayoutPanel flowComments;
    }
}
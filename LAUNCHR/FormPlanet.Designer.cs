namespace LAUNCHR
{
    partial class FormPlanet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPlanet));
            this.DragWindow = new System.Windows.Forms.Panel();
            this.LaunchrTitle = new System.Windows.Forms.Panel();
            this.Minimize = new System.Windows.Forms.Panel();
            this.ResSize = new System.Windows.Forms.Panel();
            this.Close = new System.Windows.Forms.Panel();
            this.pl_hostnameTitle = new System.Windows.Forms.Label();
            this.flowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.DragWindow.SuspendLayout();
            this.SuspendLayout();
            // 
            // DragWindow
            // 
            this.DragWindow.BackColor = System.Drawing.SystemColors.MenuText;
            this.DragWindow.Controls.Add(this.LaunchrTitle);
            this.DragWindow.Controls.Add(this.Minimize);
            this.DragWindow.Controls.Add(this.ResSize);
            this.DragWindow.Controls.Add(this.Close);
            this.DragWindow.Location = new System.Drawing.Point(0, 0);
            this.DragWindow.Name = "DragWindow";
            this.DragWindow.Size = new System.Drawing.Size(467, 32);
            this.DragWindow.TabIndex = 0;
            this.DragWindow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragWindow_MouseDown);
            this.DragWindow.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DragWindow_MouseMove);
            this.DragWindow.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DragWindow_MouseUp);
            // 
            // LaunchrTitle
            // 
            this.LaunchrTitle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LaunchrTitle.BackgroundImage")));
            this.LaunchrTitle.Location = new System.Drawing.Point(3, 0);
            this.LaunchrTitle.Name = "LaunchrTitle";
            this.LaunchrTitle.Size = new System.Drawing.Size(122, 32);
            this.LaunchrTitle.TabIndex = 3;
            // 
            // Minimize
            // 
            this.Minimize.BackgroundImage = global::LAUNCHR.Properties.Resources.universo;
            this.Minimize.Location = new System.Drawing.Point(359, 0);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(32, 32);
            this.Minimize.TabIndex = 2;
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            // 
            // ResSize
            // 
            this.ResSize.BackgroundImage = global::LAUNCHR.Properties.Resources.sun;
            this.ResSize.Location = new System.Drawing.Point(397, 0);
            this.ResSize.Name = "ResSize";
            this.ResSize.Size = new System.Drawing.Size(32, 32);
            this.ResSize.TabIndex = 1;
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.SystemColors.MenuText;
            this.Close.BackgroundImage = global::LAUNCHR.Properties.Resources.marte;
            this.Close.Location = new System.Drawing.Point(435, 0);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(32, 32);
            this.Close.TabIndex = 0;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // pl_hostnameTitle
            // 
            this.pl_hostnameTitle.AutoSize = true;
            this.pl_hostnameTitle.Location = new System.Drawing.Point(195, 52);
            this.pl_hostnameTitle.Name = "pl_hostnameTitle";
            this.pl_hostnameTitle.Size = new System.Drawing.Size(87, 13);
            this.pl_hostnameTitle.TabIndex = 2;
            this.pl_hostnameTitle.Text = "pl_hostnameTitle";
            // 
            // flowPanel
            // 
            this.flowPanel.Location = new System.Drawing.Point(12, 101);
            this.flowPanel.Name = "flowPanel";
            this.flowPanel.Size = new System.Drawing.Size(442, 433);
            this.flowPanel.TabIndex = 3;
            // 
            // FormPlanet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 555);
            this.Controls.Add(this.flowPanel);
            this.Controls.Add(this.pl_hostnameTitle);
            this.Controls.Add(this.DragWindow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPlanet";
            this.Text = "FormPlanet";
            this.DragWindow.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel DragWindow;
        private System.Windows.Forms.Panel Minimize;
        private System.Windows.Forms.Panel ResSize;
        private System.Windows.Forms.Panel Close;
        private System.Windows.Forms.Label pl_hostnameTitle;
        private System.Windows.Forms.Panel LaunchrTitle;
        private System.Windows.Forms.FlowLayoutPanel flowPanel;
    }
}
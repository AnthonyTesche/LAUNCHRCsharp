namespace LAUNCHR
{
    partial class Error
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
            this.errorAd = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DragWindow = new System.Windows.Forms.Panel();
            this.okButton = new System.Windows.Forms.Button();
            this.errorAd2 = new System.Windows.Forms.TextBox();
            this.errorAd1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorAd
            // 
            this.errorAd.BackColor = System.Drawing.SystemColors.ControlText;
            this.errorAd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.errorAd.Font = new System.Drawing.Font("Georgia", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorAd.ForeColor = System.Drawing.SystemColors.Window;
            this.errorAd.Location = new System.Drawing.Point(48, 63);
            this.errorAd.Multiline = true;
            this.errorAd.Name = "errorAd";
            this.errorAd.ReadOnly = true;
            this.errorAd.Size = new System.Drawing.Size(706, 27);
            this.errorAd.TabIndex = 0;
            this.errorAd.Text = "The Development team has already been warned about the error";
            this.errorAd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::LAUNCHR.Properties.Resources.black_hole;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.DragWindow);
            this.panel1.Controls.Add(this.okButton);
            this.panel1.Controls.Add(this.errorAd2);
            this.panel1.Controls.Add(this.errorAd1);
            this.panel1.Controls.Add(this.errorAd);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 451);
            this.panel1.TabIndex = 1;
            // 
            // DragWindow
            // 
            this.DragWindow.BackColor = System.Drawing.Color.Transparent;
            this.DragWindow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.DragWindow.Location = new System.Drawing.Point(0, 0);
            this.DragWindow.Name = "DragWindow";
            this.DragWindow.Size = new System.Drawing.Size(800, 40);
            this.DragWindow.TabIndex = 4;
            this.DragWindow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DragWindow_MouseDown);
            this.DragWindow.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DragWindow_MouseMove);
            this.DragWindow.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DragWindow_MouseUp);
            // 
            // okButton
            // 
            this.okButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.okButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.okButton.ForeColor = System.Drawing.SystemColors.Control;
            this.okButton.Location = new System.Drawing.Point(368, 381);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 3;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = false;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // errorAd2
            // 
            this.errorAd2.BackColor = System.Drawing.SystemColors.ControlText;
            this.errorAd2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.errorAd2.Font = new System.Drawing.Font("Georgia", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorAd2.ForeColor = System.Drawing.SystemColors.Window;
            this.errorAd2.Location = new System.Drawing.Point(563, 165);
            this.errorAd2.Multiline = true;
            this.errorAd2.Name = "errorAd2";
            this.errorAd2.ReadOnly = true;
            this.errorAd2.Size = new System.Drawing.Size(191, 27);
            this.errorAd2.TabIndex = 2;
            this.errorAd2.Text = "LAUNCHR Team";
            this.errorAd2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // errorAd1
            // 
            this.errorAd1.BackColor = System.Drawing.SystemColors.ControlText;
            this.errorAd1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.errorAd1.Font = new System.Drawing.Font("Georgia", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorAd1.ForeColor = System.Drawing.SystemColors.Window;
            this.errorAd1.Location = new System.Drawing.Point(192, 118);
            this.errorAd1.Multiline = true;
            this.errorAd1.Name = "errorAd1";
            this.errorAd1.ReadOnly = true;
            this.errorAd1.Size = new System.Drawing.Size(421, 27);
            this.errorAd1.TabIndex = 1;
            this.errorAd1.Text = "Restart the program to keep exploring";
            this.errorAd1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Error
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Error";
            this.Text = "Error";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox errorAd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox errorAd2;
        private System.Windows.Forms.TextBox errorAd1;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Panel DragWindow;
    }
}